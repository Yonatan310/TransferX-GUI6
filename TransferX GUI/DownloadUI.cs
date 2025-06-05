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
    public partial class DownloadUI : Form
    {
        private string downloadfrompath;
        private string downloadtopath;
        public DownloadUI(string downloadtopath, string downloadfrompath)
        {
            this.Icon = new System.Drawing.Icon("ico.ico");
            InitializeComponent();
            downloadfromBox.Text = downloadfrompath;
            downloadtoBox.Text = downloadtopath;
            string[] tag = downloadfrompath.Split('/');
            this.downloadtopath += $"{downloadtopath}//{tag[tag.Length - 1]}";
            this.downloadfrompath = downloadfrompath;
        }

        private void downloadButton_Click(object sender, EventArgs e)
        {

            bool Isworking = FileFunctions.DownloadFileFromServer(downloadfrompath, downloadtopath);


            if (Isworking)
                this.Hide();
        }


    }
}
