using TransferX_GUI.Server;
using MySql.Data.MySqlClient;
using Renci.SshNet;
using Renci.SshNet.Common;
using TransferX_GUI.client;
using static TransferX_GUI.Server.ConnectDetails;
namespace TransferX_GUI
{
    public partial class ConnectWindow : Form
    {
        public ConnectWindow()
        {
            InitializeComponent();
            this.Icon = new System.Drawing.Icon("ico.ico");

        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }



        private void LogMessage(string message)
        {
            LogsBox.AppendText($"{DateTime.Now}: {message}{Environment.NewLine}");
        }
        private async void Connect_Click(object sender, EventArgs e)
        {
            
            ConnectDetails connectDetails = new ConnectDetails
            (
                //IpAddressBox.Text,
                //PortBox.Text,
                //UsernameBox.Text,
                //PasswordBox.Text,
                //SerialKeyBox.Text,
                //ProtocolBox.Text
                "127.0.0.1",
                "22",
                UsernameBox.Text,
                "3107",
                SerialKeyBox.Text,
                "SFTP Protocol"
            );

            //if (ProtocolBox == null || string.IsNullOrEmpty(ProtocolBox.Text) || IpAddressBox == null || string.IsNullOrEmpty(IpAddressBox.Text) || PortBox == null || string.IsNullOrEmpty(PortBox.Text) || UsernameBox == null || string.IsNullOrEmpty(UsernameBox.Text) || PasswordBox == null || string.IsNullOrEmpty(PasswordBox.Text) || SerialKeyBox == null || string.IsNullOrEmpty(SerialKeyBox.Text))
            //{

            //    MessageBox.Show("Some Of The Boxes Are Empty Or Null, Check Them Before Connect.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //    return;
            //}
            LogMessage("Checking serial key...");

            await Task.Delay(2000);



            bool isValidSerialKey = connectDetails.CheckSerialKey(SerialKeyBox.Text);
            if (!isValidSerialKey)
            {
                LogMessage("Invalid serial key. Please check if you put your Serial Key Correctly!.");
                MessageBox.Show("Invalid serial key!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            LogMessage("Serial key is valid.");
            await Task.Delay(500);
            LogMessage("Connecting To The Server...");
            LogMessage($"Using Protocol: {connectDetails.GetProtocol()}");

            bool UserNameCheck = connectDetails.CheckUsername(UsernameBox.Text);
            if (!UserNameCheck)
            {

                LogMessage($"Thwre Was Problem While connecting you Too The Server");
                return;
            }

            await Task.Delay(500);



            bool isValidUser = ConnectDetails.ValidSftpCredentials(connectDetails.GetIpAddress(), int.Parse(connectDetails.GetPort()), connectDetails.GetUsername(), connectDetails.GetPassword());

            if (isValidUser)
            {
                LogMessage("User authentication successful!");
                await Task.Delay(1000);
                this.Hide();
                Main main = new Main();
                main.StartPosition = FormStartPosition.CenterScreen;
                main.Show();
            }
            else
            {
                LogMessage("User authentication failed. Check If Your Details Are Correct!");
            }
        }

    }
}
