using Azure;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TransferX_GUI
{
    public partial class TransferUI : Form
    {
        private string transferfrompath;
        private string transfertopath;

        public TransferUI(string transferfrompath, string transfertopath)
        {
            this.Icon = new System.Drawing.Icon("ico.ico");
            InitializeComponent();
            transferfromBox.Text = transferfrompath;
            transfertoBox.Text = transfertopath;
            string[] tag = transferfrompath.Split('\\');
            this.transfertopath += $"{transfertopath}//{tag[tag.Length - 1]}";
            this.transferfrompath = transferfrompath;
        }

        public void transferButton_Click(object sender, EventArgs e)
        {
            bool Isworking = FileFunctions.UploadFileToServer(transferfrompath, transfertopath);
            if (Isworking)
                this.Hide();
        }

    }

}
