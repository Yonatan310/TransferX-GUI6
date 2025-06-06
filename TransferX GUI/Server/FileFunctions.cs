using System;
using System.IO;
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
    public static bool UploadFileToServer(string transferfrom, string transferto)
    {
        using (var transferxclient = new SftpClient(ConnectDetails.IpAddress, int.Parse(ConnectDetails.Port), ConnectDetails.Username, ConnectDetails.Password))
        {
            try
            {

                transferxclient.Connect();

                using (var fileStream = new FileStream(transferfrom, FileMode.Open, FileAccess.Read))
                {
                    transferxclient.UploadFile(fileStream, transferto);
                }

                MessageBox.Show($"File Successfully Uploaded From: {transferfrom} to {transferto}, Refreshing...", "Debug", MessageBoxButtons.OK, MessageBoxIcon.Information);
                mainForm.RefreshTool_Click(null, null);
                transferxclient.Disconnect();
            }
            catch (Exception ex)
            {
                if (transferxclient.IsConnected)
                    transferxclient.Disconnect();

                MessageBox.Show($"An error occurred:\n{ex.ToString()}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }
        return true;
    }

    public static bool DownloadFileFromServer(string downloadfrom, string downloadto)
    {
        using (var transferxclient = new SftpClient(ConnectDetails.IpAddress, int.Parse(ConnectDetails.Port), ConnectDetails.Username, ConnectDetails.Password))
        {
            try
            {

                transferxclient.Connect();

                using (var fileStream = new FileStream(downloadto, FileMode.Create, FileAccess.Write))
                {
                    transferxclient.DownloadFile(downloadfrom, fileStream);
                }

                MessageBox.Show($"File Successfully Downloaded From: {downloadfrom} to {downloadto}, Refreshing...", "Debug", MessageBoxButtons.OK, MessageBoxIcon.Information);
                mainForm.RefreshTool_Click(null, null);
                transferxclient.Disconnect();
                return true;
            }
            catch (Exception ex)
            {
                if (transferxclient.IsConnected)
                    transferxclient.Disconnect();

                MessageBox.Show($"An error occurred:\n{ex.ToString()}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }
    }
}