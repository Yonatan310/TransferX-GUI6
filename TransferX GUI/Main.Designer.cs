using TransferX_GUI.client;

namespace TransferX_GUI
{
    partial class Main
    {

        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            panel1 = new Panel();
            ToolsBox = new ToolStrip();
            ConnectTool = new ToolStripButton();
            toolStripSeparator4 = new ToolStripSeparator();
            toolStripSeparator6 = new ToolStripSeparator();
            RefreshTool = new ToolStripButton();
            toolStripSeparator7 = new ToolStripSeparator();
            TransferFile = new ToolStripButton();
            toolStripSeparator5 = new ToolStripSeparator();
            DownloadFile = new ToolStripButton();
            User1Files = new TreeView();
            User2Files = new TreeView();
            ToolsText = new Label();
            User1Text = new Label();
            User2Text = new Label();
            label1 = new Label();
            AddressBoxLocal = new TextBox();
            AddressBoxServer = new TextBox();
            panel1.SuspendLayout();
            ToolsBox.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(ToolsBox);
            panel1.Location = new Point(12, 54);
            panel1.Name = "panel1";
            panel1.Size = new Size(786, 57);
            panel1.TabIndex = 2;
            // 
            // ToolsBox
            // 
            ToolsBox.ImageScalingSize = new Size(49, 49);
            ToolsBox.Items.AddRange(new ToolStripItem[] { ConnectTool, toolStripSeparator4, toolStripSeparator6, RefreshTool, toolStripSeparator7, TransferFile, toolStripSeparator5, DownloadFile });
            ToolsBox.Location = new Point(0, 0);
            ToolsBox.Name = "ToolsBox";
            ToolsBox.Size = new Size(786, 56);
            ToolsBox.TabIndex = 0;
            ToolsBox.Text = "ToolsBox";
            // 
            // ConnectTool
            // 
            ConnectTool.DisplayStyle = ToolStripItemDisplayStyle.Image;
            ConnectTool.Image = (Image)resources.GetObject("ConnectTool.Image");
            ConnectTool.ImageTransparentColor = Color.Magenta;
            ConnectTool.Name = "ConnectTool";
            ConnectTool.Size = new Size(53, 53);
            ConnectTool.Text = "toolStripButton1";
            ConnectTool.ToolTipText = "Connect To A Server";
            ConnectTool.Click += ConnectTool_Click;
            // 
            // toolStripSeparator4
            // 
            toolStripSeparator4.Name = "toolStripSeparator4";
            toolStripSeparator4.Size = new Size(6, 56);
            // 
            // toolStripSeparator6
            // 
            toolStripSeparator6.Name = "toolStripSeparator6";
            toolStripSeparator6.Size = new Size(6, 56);
            // 
            // RefreshTool
            // 
            RefreshTool.DisplayStyle = ToolStripItemDisplayStyle.Image;
            RefreshTool.Image = (Image)resources.GetObject("RefreshTool.Image");
            RefreshTool.ImageTransparentColor = Color.Magenta;
            RefreshTool.Name = "RefreshTool";
            RefreshTool.Size = new Size(53, 53);
            RefreshTool.Text = "toolStripButton1";
            RefreshTool.ToolTipText = "Refresh";
            RefreshTool.Click += RefreshTool_Click;
            // 
            // toolStripSeparator7
            // 
            toolStripSeparator7.Name = "toolStripSeparator7";
            toolStripSeparator7.Size = new Size(6, 56);
            // 
            // TransferFile
            // 
            TransferFile.DisplayStyle = ToolStripItemDisplayStyle.Image;
            TransferFile.Image = (Image)resources.GetObject("TransferFile.Image");
            TransferFile.ImageTransparentColor = Color.Magenta;
            TransferFile.Name = "TransferFile";
            TransferFile.Size = new Size(53, 53);
            TransferFile.Text = "toolStripButton5";
            TransferFile.ToolTipText = "Transfer File";
            TransferFile.Click += TransferFile_Click;
            // 
            // toolStripSeparator5
            // 
            toolStripSeparator5.Name = "toolStripSeparator5";
            toolStripSeparator5.Size = new Size(6, 56);
            // 
            // DownloadFile
            // 
            DownloadFile.DisplayStyle = ToolStripItemDisplayStyle.Image;
            DownloadFile.Image = (Image)resources.GetObject("DownloadFile.Image");
            DownloadFile.ImageTransparentColor = Color.Magenta;
            DownloadFile.Name = "DownloadFile";
            DownloadFile.Size = new Size(53, 53);
            DownloadFile.Text = "Download File";
            DownloadFile.ToolTipText = "Download File";
            DownloadFile.Click += DownloadFile_Click;
            // 
            // User1Files
            // 
            User1Files.Location = new Point(12, 144);
            User1Files.Name = "User1Files";
            User1Files.Size = new Size(786, 688);
            User1Files.TabIndex = 3;
            User1Files.AfterSelect += User1Files_AfterSelect;
            // 
            // User2Files
            // 
            User2Files.Location = new Point(804, 144);
            User2Files.Name = "User2Files";
            User2Files.Size = new Size(768, 688);
            User2Files.TabIndex = 4;
            User2Files.AfterSelect += User2Files_AfterSelect;
            // 
            // ToolsText
            // 
            ToolsText.AutoSize = true;
            ToolsText.ForeColor = SystemColors.Desktop;
            ToolsText.Location = new Point(12, 36);
            ToolsText.Name = "ToolsText";
            ToolsText.Size = new Size(37, 15);
            ToolsText.TabIndex = 5;
            ToolsText.Text = "Tools:";
            // 
            // User1Text
            // 
            User1Text.AutoSize = true;
            User1Text.ForeColor = SystemColors.ControlText;
            User1Text.Location = new Point(12, 126);
            User1Text.Name = "User1Text";
            User1Text.Size = new Size(64, 15);
            User1Text.TabIndex = 6;
            User1Text.Text = "Local Files:";
            // 
            // User2Text
            // 
            User2Text.AutoSize = true;
            User2Text.ForeColor = SystemColors.ControlText;
            User2Text.Location = new Point(804, 126);
            User2Text.Name = "User2Text";
            User2Text.Size = new Size(68, 15);
            User2Text.TabIndex = 7;
            User2Text.Text = "Server Files:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 13F);
            label1.ForeColor = SystemColors.ButtonShadow;
            label1.Location = new Point(625, 833);
            label1.Name = "label1";
            label1.Size = new Size(385, 25);
            label1.TabIndex = 8;
            label1.Text = "TransferX Client 1.0.0 - All Copyrights Reserved.";
            // 
            // AddressBoxLocal
            // 
            AddressBoxLocal.BackColor = SystemColors.GradientInactiveCaption;
            AddressBoxLocal.Location = new Point(12, 809);
            AddressBoxLocal.Name = "AddressBoxLocal";
            AddressBoxLocal.ReadOnly = true;
            AddressBoxLocal.Size = new Size(786, 23);
            AddressBoxLocal.TabIndex = 9;
            // 
            // AddressBoxServer
            // 
            AddressBoxServer.BackColor = SystemColors.GradientInactiveCaption;
            AddressBoxServer.Location = new Point(804, 809);
            AddressBoxServer.Name = "AddressBoxServer";
            AddressBoxServer.ReadOnly = true;
            AddressBoxServer.Size = new Size(768, 23);
            AddressBoxServer.TabIndex = 10;
            // 
            // Main
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1584, 861);
            Controls.Add(AddressBoxServer);
            Controls.Add(AddressBoxLocal);
            Controls.Add(label1);
            Controls.Add(User2Text);
            Controls.Add(User1Text);
            Controls.Add(ToolsText);
            Controls.Add(User2Files);
            Controls.Add(User1Files);
            Controls.Add(panel1);
            ForeColor = SystemColors.ButtonShadow;
            Name = "Main";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Main";
            Load += Main_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ToolsBox.ResumeLayout(false);
            ToolsBox.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Panel panel1;
        private TreeView User1Files;
        private TreeView User2Files;
        private ToolStrip ToolsBox;
        private ToolStripButton ConnectTool;
        private ToolStripButton AddFolderTool;
        private ToolStripButton AddFileTool;
        private ToolStripButton CopyTool;
        private ToolStripButton TransferFile;
        private ToolStripButton RefreshTool;
        private Label ToolsText;
        private Label User1Text;
        private ToolStripSeparator toolStripSeparator5;
        private ToolStripButton DownloadFile;
        private Label User2Text;
        private Label label1;
        private TextBox AddressBoxLocal;

        public TextBox GetPathTextBox()
        {
            return AddressBoxLocal;
        }

        private TextBox AddressBoxServer;
        private ToolStripSeparator toolStripSeparator4;
        private ToolStripSeparator toolStripSeparator7;
        private ToolStripSeparator toolStripSeparator6;



        public void RefreshTool_Click(object sender, EventArgs e)
        {
            User1Files.Nodes.Clear();
            User2Files.Nodes.Clear();
            UsersFiles.ShowTreeViewForUser1();
            UsersFiles.ShowTreeViewForUser2();
        }
    }
}