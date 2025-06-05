namespace TransferX_GUI
{
    partial class ConnectWindow
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            button2 = new Button();
            button1 = new Button();
            IpAddressText = new Label();
            IpAddressBox = new TextBox();
            PortBox = new TextBox();
            PortNumberText = new Label();
            LogsBox = new TextBox();
            UsernameText = new Label();
            UsernameBox = new TextBox();
            PasswordText = new Label();
            PasswordBox = new TextBox();
            SessionGroupBox = new GroupBox();
            SerialKeyText = new Label();
            SerialKeyBox = new TextBox();
            ProtocolText = new Label();
            ProtocolBox = new ComboBox();
            Session = new Label();
            colorDialog1 = new ColorDialog();
            LogsGroupBox = new GroupBox();
            SessionGroupBox.SuspendLayout();
            LogsGroupBox.SuspendLayout();
            SuspendLayout();
            // 
            // button2
            // 
            button2.Location = new Point(602, 257);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 1;
            button2.Text = "Help";
            button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 9F);
            button1.Location = new Point(521, 257);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 2;
            button1.Text = "Connect";
            button1.UseVisualStyleBackColor = true;
            button1.Click += Connect_Click;
            // 
            // IpAddressText
            // 
            IpAddressText.AutoSize = true;
            IpAddressText.ForeColor = Color.Black;
            IpAddressText.Location = new Point(6, 27);
            IpAddressText.Name = "IpAddressText";
            IpAddressText.RightToLeft = RightToLeft.No;
            IpAddressText.Size = new Size(65, 15);
            IpAddressText.TabIndex = 3;
            IpAddressText.Text = "IP Address:";
            // 
            // IpAddressBox
            // 
            IpAddressBox.Location = new Point(6, 45);
            IpAddressBox.Multiline = true;
            IpAddressBox.Name = "IpAddressBox";
            IpAddressBox.Size = new Size(204, 21);
            IpAddressBox.TabIndex = 4;
            IpAddressBox.TextAlign = HorizontalAlignment.Right;
            // 
            // PortBox
            // 
            PortBox.Location = new Point(216, 45);
            PortBox.Multiline = true;
            PortBox.Name = "PortBox";
            PortBox.Size = new Size(93, 21);
            PortBox.TabIndex = 5;
            PortBox.TextAlign = HorizontalAlignment.Right;
            // 
            // PortNumberText
            // 
            PortNumberText.AutoSize = true;
            PortNumberText.ForeColor = Color.Black;
            PortNumberText.Location = new Point(216, 27);
            PortNumberText.Name = "PortNumberText";
            PortNumberText.RightToLeft = RightToLeft.No;
            PortNumberText.Size = new Size(77, 15);
            PortNumberText.TabIndex = 6;
            PortNumberText.Text = "Port number:";
            // 
            // LogsBox
            // 
            LogsBox.Font = new Font("Segoe UI", 9F);
            LogsBox.Location = new Point(9, 22);
            LogsBox.Multiline = true;
            LogsBox.Name = "LogsBox";
            LogsBox.ReadOnly = true;
            LogsBox.Size = new Size(316, 187);
            LogsBox.TabIndex = 7;
            // 
            // UsernameText
            // 
            UsernameText.AutoSize = true;
            UsernameText.ForeColor = Color.Black;
            UsernameText.Location = new Point(6, 91);
            UsernameText.Name = "UsernameText";
            UsernameText.Size = new Size(63, 15);
            UsernameText.TabIndex = 8;
            UsernameText.Text = ":Username";
            // 
            // UsernameBox
            // 
            UsernameBox.Location = new Point(6, 109);
            UsernameBox.Multiline = true;
            UsernameBox.Name = "UsernameBox";
            UsernameBox.RightToLeft = RightToLeft.No;
            UsernameBox.Size = new Size(155, 21);
            UsernameBox.TabIndex = 9;
            // 
            // PasswordText
            // 
            PasswordText.AutoSize = true;
            PasswordText.ForeColor = Color.Black;
            PasswordText.Location = new Point(167, 91);
            PasswordText.Name = "PasswordText";
            PasswordText.RightToLeft = RightToLeft.No;
            PasswordText.Size = new Size(60, 15);
            PasswordText.TabIndex = 10;
            PasswordText.Text = "Password:";
            // 
            // PasswordBox
            // 
            PasswordBox.Location = new Point(167, 109);
            PasswordBox.Multiline = true;
            PasswordBox.Name = "PasswordBox";
            PasswordBox.PasswordChar = '*';
            PasswordBox.RightToLeft = RightToLeft.No;
            PasswordBox.Size = new Size(142, 21);
            PasswordBox.TabIndex = 11;
            // 
            // SessionGroupBox
            // 
            SessionGroupBox.BackColor = SystemColors.Control;
            SessionGroupBox.BackgroundImageLayout = ImageLayout.None;
            SessionGroupBox.Controls.Add(SerialKeyText);
            SessionGroupBox.Controls.Add(SerialKeyBox);
            SessionGroupBox.Controls.Add(ProtocolText);
            SessionGroupBox.Controls.Add(ProtocolBox);
            SessionGroupBox.Controls.Add(PasswordText);
            SessionGroupBox.Controls.Add(PortNumberText);
            SessionGroupBox.Controls.Add(PasswordBox);
            SessionGroupBox.Controls.Add(PortBox);
            SessionGroupBox.Controls.Add(Session);
            SessionGroupBox.Controls.Add(IpAddressBox);
            SessionGroupBox.Controls.Add(UsernameBox);
            SessionGroupBox.Controls.Add(IpAddressText);
            SessionGroupBox.Controls.Add(UsernameText);
            SessionGroupBox.ForeColor = Color.CornflowerBlue;
            SessionGroupBox.Location = new Point(13, 29);
            SessionGroupBox.Name = "SessionGroupBox";
            SessionGroupBox.Size = new Size(318, 251);
            SessionGroupBox.TabIndex = 12;
            SessionGroupBox.TabStop = false;
            // 
            // SerialKeyText
            // 
            SerialKeyText.AutoSize = true;
            SerialKeyText.ForeColor = Color.Black;
            SerialKeyText.Location = new Point(6, 146);
            SerialKeyText.Name = "SerialKeyText";
            SerialKeyText.RightToLeft = RightToLeft.No;
            SerialKeyText.Size = new Size(60, 15);
            SerialKeyText.TabIndex = 15;
            SerialKeyText.Text = "Serial Key:";
            // 
            // SerialKeyBox
            // 
            SerialKeyBox.Location = new Point(6, 167);
            SerialKeyBox.Multiline = true;
            SerialKeyBox.Name = "SerialKeyBox";
            SerialKeyBox.PasswordChar = '•';
            SerialKeyBox.RightToLeft = RightToLeft.No;
            SerialKeyBox.Size = new Size(303, 21);
            SerialKeyBox.TabIndex = 14;
            // 
            // ProtocolText
            // 
            ProtocolText.AutoSize = true;
            ProtocolText.ForeColor = Color.Black;
            ProtocolText.Location = new Point(6, 204);
            ProtocolText.Name = "ProtocolText";
            ProtocolText.RightToLeft = RightToLeft.No;
            ProtocolText.Size = new Size(55, 15);
            ProtocolText.TabIndex = 13;
            ProtocolText.Text = "Protocol:";
            ProtocolText.UseMnemonic = false;
            // 
            // ProtocolBox
            // 
            ProtocolBox.BackColor = SystemColors.Control;
            ProtocolBox.ForeColor = Color.Black;
            ProtocolBox.FormattingEnabled = true;
            ProtocolBox.Items.AddRange(new object[] { "SFTP Protocol", "FTP Protocol" });
            ProtocolBox.Location = new Point(6, 222);
            ProtocolBox.Name = "ProtocolBox";
            ProtocolBox.RightToLeft = RightToLeft.No;
            ProtocolBox.Size = new Size(303, 23);
            ProtocolBox.TabIndex = 12;
            // 
            // Session
            // 
            Session.AutoSize = true;
            Session.ForeColor = Color.Black;
            Session.Location = new Point(6, 0);
            Session.Name = "Session";
            Session.Size = new Size(46, 15);
            Session.TabIndex = 0;
            Session.Text = "Session";
            // 
            // LogsGroupBox
            // 
            LogsGroupBox.Controls.Add(LogsBox);
            LogsGroupBox.Location = new Point(346, 29);
            LogsGroupBox.Name = "LogsGroupBox";
            LogsGroupBox.RightToLeft = RightToLeft.No;
            LogsGroupBox.Size = new Size(331, 222);
            LogsGroupBox.TabIndex = 13;
            LogsGroupBox.TabStop = false;
            LogsGroupBox.Text = "Logs:";
            // 
            // ConnectWindow
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(689, 292);
            Controls.Add(button1);
            Controls.Add(button2);
            Controls.Add(SessionGroupBox);
            Controls.Add(LogsGroupBox);
            ForeColor = SystemColors.ActiveCaptionText;
            Name = "ConnectWindow";
            RightToLeft = RightToLeft.Yes;
            Text = "Connect To Server";
            Load += Form1_Load;
            SessionGroupBox.ResumeLayout(false);
            SessionGroupBox.PerformLayout();
            LogsGroupBox.ResumeLayout(false);
            LogsGroupBox.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button button2;
        private Button button1;
        private Label IpAddressText;
        private TextBox IpAddressBox;
        private TextBox PortBox;
        private Label PortNumberText;
        private TextBox LogsBox;
        private Label UsernameText;
        private TextBox UsernameBox;
        private Label PasswordText;
        private TextBox PasswordBox;
        private GroupBox SessionGroupBox;
        private Label Session;
        private ColorDialog colorDialog1;
        private ComboBox ProtocolBox;
        private Label ProtocolText;
        private GroupBox LogsGroupBox;
        private TextBox SerialKeyBox;
        private Label SerialKeyText;
    }
}
