using System;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;

namespace TransferX_GUI
{
    static class Rsa
    {
        private static string rsaPublicKey = "";
        private static string rsaPrivateKey = "";
        private static string Serverpublickey = "";

        public static void generate()
        {
            using (RSA rsa = RSA.Create())
            {
                rsaPrivateKey = rsa.ToXmlString(true);
                rsaPublicKey = rsa.ToXmlString(false);
            }
        }

        public static byte[] Encrypt(string Str)
        {
            try
            {
                using (RSA rsa = RSA.Create())
                {
                    rsa.FromXmlString(Serverpublickey);
                    byte[] bytes = Encoding.UTF8.GetBytes(Str);
                    return rsa.Encrypt(bytes, RSAEncryptionPadding.Pkcs1);
                }
            }
            catch (Exception e)
            {
                return null;
            }
        }

        public static string decrypt(byte[] bytes)
        {
            try
            {
                using (RSA rsa = RSA.Create())
                {
                    rsa.FromXmlString(rsaPrivateKey);

                    return Encoding.UTF8.GetString(rsa.Decrypt(bytes, RSAEncryptionPadding.Pkcs1));
                }
            }
            catch (Exception e)
            {
                return "";
            }
        }

        public static void SetServerPublicKey(byte[] pk)
        {
            Serverpublickey = Encoding.UTF8.GetString(pk);
        }

        public static byte[] getRsaPublicKey()
        {
            return Encoding.UTF8.GetBytes(rsaPublicKey);
        }
    }
}
