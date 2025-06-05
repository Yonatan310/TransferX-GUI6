namespace TransferX_GUI
{
    partial class DownloadUI
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
            downloadfromBox = new TextBox();
            downloadtoBox = new TextBox();
            downloadfrom = new Label();
            downloadto = new Label();
            downloadButton = new Button();
            SuspendLayout();
            // 
            // downloadfromBox
            // 
            downloadfromBox.Location = new Point(12, 50);
            downloadfromBox.Name = "downloadfromBox";
            downloadfromBox.Size = new Size(326, 23);
            downloadfromBox.TabIndex = 0;
            // 
            // downloadtoBox
            // 
            downloadtoBox.Location = new Point(12, 106);
            downloadtoBox.Name = "downloadtoBox";
            downloadtoBox.Size = new Size(326, 23);
            downloadtoBox.TabIndex = 1;
            // 
            // downloadfrom
            // 
            downloadfrom.AutoSize = true;
            downloadfrom.Location = new Point(12, 32);
            downloadfrom.Name = "downloadfrom";
            downloadfrom.Size = new Size(95, 15);
            downloadfrom.TabIndex = 2;
            downloadfrom.Text = "Download From:";
            // 
            // downloadto
            // 
            downloadto.AutoSize = true;
            downloadto.Location = new Point(12, 88);
            downloadto.Name = "downloadto";
            downloadto.Size = new Size(79, 15);
            downloadto.TabIndex = 3;
            downloadto.Text = "Download To:";
            // 
            // downloadButton
            // 
            downloadButton.Location = new Point(98, 162);
            downloadButton.Name = "downloadButton";
            downloadButton.Size = new Size(150, 23);
            downloadButton.TabIndex = 4;
            downloadButton.Text = "Download";
            downloadButton.UseVisualStyleBackColor = true;
            downloadButton.Click += downloadButton_Click;
            // 
            // DownloadUI
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(352, 197);
            Controls.Add(downloadButton);
            Controls.Add(downloadto);
            Controls.Add(downloadfrom);
            Controls.Add(downloadtoBox);
            Controls.Add(downloadfromBox);
            Name = "DownloadUI";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "DownloadUI";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox downloadfromBox;
        private TextBox downloadtoBox;
        private Label downloadfrom;
        private Label downloadto;
        private Button downloadButton;
    }
}