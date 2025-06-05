using System;
using System.IO;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;
using Renci.SshNet;
using TransferX_GUI;
using TransferX_GUI.Server;

static class FileFunctions
{
    private static Main mainForm;

    public static void setMainForm(Main f)
    {
        mainForm = f;
    }

    public static string GenerateRandomKey()
    {
        using (var aes = Aes.Create())
        {
            aes.GenerateKey();
            return Convert.ToBase64String(aes.Key);
        }
    }

    public static bool UploadFileToServer(string transferfrom, string transferto)
    {
        string aesKey = Environment.GetEnvironmentVariable("AES_KEY");

        if (string.IsNullOrEmpty(aesKey))
        {
            MessageBox.Show("AES Key is missing in the environment variable.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return false;
        }

        using (Aes aesAlg = Aes.Create())
        {
            aesAlg.Key = Convert.FromBase64String(aesKey);
            aesAlg.GenerateIV(); // Generate a new IV for each upload

            try
            {
                using (var transferxclient = new SftpClient(ConnectDetails.IpAddress, int.Parse(ConnectDetails.Port), ConnectDetails.Username, ConnectDetails.Password))
                {
                    transferxclient.Connect();

                    using (var fileStream = new FileStream(transferfrom, FileMode.Open, FileAccess.Read))
                    using (var memoryStream = new MemoryStream())
                    using (var cryptoStream = new CryptoStream(memoryStream, aesAlg.CreateEncryptor(), CryptoStreamMode.Write))
                    {
                        byte[] iv = aesAlg.IV;
                        memoryStream.Write(iv, 0, iv.Length); // Write IV at the beginning of the encrypted file
                        fileStream.CopyTo(cryptoStream);

                        byte[] encryptedFile = memoryStream.ToArray();
                        using (var encryptedStream = new MemoryStream(encryptedFile))
                        {
                            transferxclient.UploadFile(encryptedStream, transferto);
                        }
                    }

                    MessageBox.Show($"File Successfully Uploaded From: {transferfrom} to {transferto}, Refreshing...", "Debug", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    mainForm.RefreshTool_Click(null, null);
                    transferxclient.Disconnect();
                }

                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred:\n{ex.ToString()}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }
    }

    public static bool DownloadFileFromServer(string downloadfrom, string downloadto)
    {
        string aesKey = Environment.GetEnvironmentVariable("AES_KEY");

        if (string.IsNullOrEmpty(aesKey))
        {
            MessageBox.Show("AES Key is missing in the environment variable.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return false;
        }

        using (Aes aesAlg = Aes.Create())
        {
            aesAlg.Key = Convert.FromBase64String(aesKey);

            try
            {
                using (var transferxclient = new SftpClient(ConnectDetails.IpAddress, int.Parse(ConnectDetails.Port), ConnectDetails.Username, ConnectDetails.Password))
                {
                    transferxclient.Connect();

                    using (var fileStream = new MemoryStream())
                    {
                        transferxclient.DownloadFile(downloadfrom, fileStream);
                        byte[] encryptedContent = fileStream.ToArray();

                        // Extract IV from the encrypted content
                        byte[] iv = new byte[aesAlg.BlockSize / 8];
                        Array.Copy(encryptedContent, 0, iv, 0, iv.Length);

                        using (var memoryStream = new MemoryStream(encryptedContent, iv.Length, encryptedContent.Length - iv.Length))
                        using (var cryptoStream = new CryptoStream(memoryStream, aesAlg.CreateDecryptor(aesAlg.Key, iv), CryptoStreamMode.Read))
                        using (var decryptedStream = new MemoryStream())
                        {
                            cryptoStream.CopyTo(decryptedStream);
                            File.WriteAllBytes(downloadto, decryptedStream.ToArray());
                        }
                    }

                    MessageBox.Show($"File Successfully Downloaded From: {downloadfrom} to {downloadto}, Refreshing...", "Debug", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    mainForm.RefreshTool_Click(null, null);
                    transferxclient.Disconnect();

                    return true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred:\n{ex.ToString()}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }
    }
}
