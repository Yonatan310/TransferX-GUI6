using System;
using System.Drawing;
using System.IO;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using TransferX_GUI.client;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using Renci.SshNet;
using MySql.Data.MySqlClient;
using Renci.SshNet.Common;

namespace TransferX_GUI
{
    public partial class Main : Form
    {

        public Main()
        {
            InitializeComponent();
            FileFunctions.setMainForm(this);
            this.Icon = new System.Drawing.Icon("ico.ico");
            UsersFiles.SetUser1TreeView(User1Files);
            UsersFiles.ShowTreeViewForUser1();

            UsersFiles.SetUser2TreeView(User2Files);
            UsersFiles.ShowTreeViewForUser2();
            FormClosed += (s, args) => Application.Exit();
        }

        public void User1Files_AfterSelect(object sender, TreeViewEventArgs e)
        {
            AddressBoxLocal.Text = e.Node.Tag?.ToString();
        }

        public void User2Files_AfterSelect(object sender, TreeViewEventArgs e)
        {
            AddressBoxServer.Text = e.Node.Tag?.ToString();
        }



        private void Main_Load(object sender, EventArgs e)
        {

        }

        private void TransferFile_Click(object sender, EventArgs e)
        {
            string User1FilesTag = "";
            string User2FilesTag = "";

            if (User1Files.SelectedNode?.Tag == null)
                User2FilesTag = "Select Folder!";
            else
                User2FilesTag = User1Files.SelectedNode.Tag.ToString();
            if (User2Files.SelectedNode?.Tag == null)
                User1FilesTag = "Select File!";
            else
                User1FilesTag = User2Files.SelectedNode.Tag.ToString();

            TransferUI transferui = new TransferUI(User1FilesTag, User2FilesTag);
            transferui.Show();
        }

        private void DownloadFile_Click(object sender, EventArgs e)
        {
            string User2FilesTag;
            string User1FilesTag;

            if (User1Files.SelectedNode?.Tag == null)
                User2FilesTag = "Select Folder!";
            else
                User2FilesTag = User1Files.SelectedNode.Tag.ToString();
            if (User2Files.SelectedNode?.Tag == null)
                User1FilesTag = "Select File!";
            else
                User1FilesTag = User2Files.SelectedNode.Tag.ToString();

            DownloadUI downloadui = new DownloadUI(User2FilesTag, User1FilesTag);
            downloadui.Show();
        }

        private void ConnectTool_Click(object sender, EventArgs e)
        {
            ConnectWindow connectWindow = new ConnectWindow();
            connectWindow.Show();
            
            this.Hide();
            
        }
    }
}

