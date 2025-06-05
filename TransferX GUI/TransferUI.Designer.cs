namespace TransferX_GUI
{
    partial class TransferUI
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
            transferfrom = new Label();
            transferfromBox = new TextBox();
            transfertoBox = new TextBox();
            transferto = new Label();
            transferButton = new Button();
            SuspendLayout();
            // 
            // transferfrom
            // 
            transferfrom.AutoSize = true;
            transferfrom.Location = new Point(12, 31);
            transferfrom.Name = "transferfrom";
            transferfrom.Size = new Size(82, 15);
            transferfrom.TabIndex = 0;
            transferfrom.Text = "Transfer From:";
            // 
            // transferfromBox
            // 
            transferfromBox.Location = new Point(12, 49);
            transferfromBox.Name = "transferfromBox";
            transferfromBox.Size = new Size(323, 23);
            transferfromBox.TabIndex = 1;
            // 
            // transfertoBox
            // 
            transfertoBox.Location = new Point(12, 105);
            transfertoBox.Name = "transfertoBox";
            transfertoBox.Size = new Size(323, 23);
            transfertoBox.TabIndex = 2;
            // 
            // transferto
            // 
            transferto.AutoSize = true;
            transferto.Location = new Point(12, 87);
            transferto.Name = "transferto";
            transferto.Size = new Size(66, 15);
            transferto.TabIndex = 3;
            transferto.Text = "Transfer To:";
            // 
            // transferButton
            // 
            transferButton.Location = new Point(97, 162);
            transferButton.Name = "transferButton";
            transferButton.Size = new Size(154, 23);
            transferButton.TabIndex = 5;
            transferButton.Text = "Transfer";
            transferButton.UseVisualStyleBackColor = true;
            transferButton.Click += transferButton_Click;
            // 
            // TransferUI
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(350, 197);
            Controls.Add(transferButton);
            Controls.Add(transferto);
            Controls.Add(transfertoBox);
            Controls.Add(transferfromBox);
            Controls.Add(transferfrom);
            Name = "TransferUI";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "TransferUI";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label transferfrom;
        private TextBox transferfromBox;
        private TextBox transfertoBox;
        private Label transferto;
        private Button transferButton;
    }
}