using MySql.Data.MySqlClient;
using Renci.SshNet;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Renci.SshNet.Common;
using System.Net.Sockets;
using System.Net;
using MySqlX.XDevAPI;

namespace TransferX_GUI.Server
{
    internal class ConnectDetails
    {
        public static string IpAddress;
        public static string Port;
        public static string Username;
        public static string Password;
        public static string SerialKey;
        public static string Protocol;
        public static string CurrentUser;
        private static Socket ServerConnection;
        





        public bool CheckUsername(string username)
        {

            byte[] s = Rsa.Encrypt(username);
            ServerConnection.Send(Encoding.UTF8.GetBytes(s.Length.ToString()));
            Thread.Sleep(200);
            ServerConnection.Send(s);


            byte[] bytes = new byte[100];
            int bytesread = ServerConnection.Receive(bytes);
            bytes = new byte[int.Parse(Encoding.UTF8.GetString(bytes, 0, bytesread))];
            ServerConnection.Receive(bytes);


            if (Rsa.decrypt(bytes) == "0")
            {
                return false;
            }  

            return true;

        }

        public bool CheckSerialKey(string serialkey)
        {
            ServerConnection = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            IPEndPoint en = new IPEndPoint(IPAddress.Parse(IpAddress), 50000);
            ServerConnection.Connect(en);

            byte[] publickeybytes = new byte[243];

            ServerConnection.Send(Rsa.getRsaPublicKey());
            
            ServerConnection.Receive(publickeybytes);
            
            Rsa.SetServerPublicKey(publickeybytes);

            byte[] s = Rsa.Encrypt(serialkey);

            ServerConnection.Send(Encoding.UTF8.GetBytes(s.Length.ToString()));
            Thread.Sleep(200);
            ServerConnection.Send(s);


            byte[] bytes = new byte[100];
            int bytesread = ServerConnection.Receive(bytes);
            bytes = new byte[int.Parse(Encoding.UTF8.GetString(bytes, 0, bytesread))];
            ServerConnection.Receive(bytes);


            if (Rsa.decrypt(bytes) == "0")
            {
                return false;
            }

            return true;

        }
        public ConnectDetails(string ipAddress, string port, string username, string password, string serialkey, string protocol)
        {
            IpAddress = ipAddress;
            Port = port;
            Username = username;
            Password = password;
            SerialKey = serialkey;
            Protocol = protocol;
        }
        public string GetIpAddress() { return IpAddress; }
        public string GetPort() { return Port; }
        public string GetUsername() { return Username; }
        public string GetPassword() { return Password; }
        public string GetSerialKey() { return SerialKey; }
        public string GetProtocol() { return Protocol; }
        public string GetCurrentUser() { return CurrentUser; }

        public void SetIpAddress(string ipAddress) { IpAddress = ipAddress; }
        public void SetPort(string port) { Port = port; }
        public void SetUsername(string username) { Username = username; }
        public void SetPassword(string password) { Password = password; }
        public void SetSerialKey(string serialkey) { SerialKey = serialkey; }
        public void SetProtocol(string protocol) { Protocol = protocol; }
        public void SetCurrentUser(string currentuser) { CurrentUser = currentuser; }
        public static void SetTheCurrentUserByUsername(string username)
        {
            CurrentUser = username;
        }
        public static void SetDetails(string ipAddress, string port, string username, string password, string serialkey, string protocol)
        {
            IpAddress = ipAddress;
            Port = port;
            Username = username;
            Password = password;
            SerialKey = serialkey;
            Protocol = protocol;

        }

       
        public static bool ValidSftpCredentials(string ipAddress, int port, string username, string password)
        {
            try
            {

                using (var transferxclient = new SftpClient(ipAddress, port, username, password))
                {
                    transferxclient.Connect();
                    if (transferxclient.IsConnected)
                    {
                        if (!transferxclient.Exists("/sftp_root"))
                        {
                            transferxclient.CreateDirectory("/sftp_root");
                        }
                        SetTheCurrentUserByUsername(username); 
                        return true;
                    }
                }
            }
            catch (FormatException ex)
            {

                MessageBox.Show($"Invalid input format: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {

                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return false;
        }



    }

}