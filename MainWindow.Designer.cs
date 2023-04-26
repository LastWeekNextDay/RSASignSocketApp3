namespace RSASignatureApplication3
{
    partial class MainWindow
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
            this.publicKeyLabel = new System.Windows.Forms.Label();
            this.nLabel = new System.Windows.Forms.Label();
            this.eLabel = new System.Windows.Forms.Label();
            this.digitalSignLabel = new System.Windows.Forms.Label();
            this.messageLabel = new System.Windows.Forms.Label();
            this.messageTextBox = new System.Windows.Forms.RichTextBox();
            this.verifyButton = new System.Windows.Forms.Button();
            this.verificationLabel = new System.Windows.Forms.Label();
            this.nTextBox = new System.Windows.Forms.RichTextBox();
            this.eTextBox = new System.Windows.Forms.RichTextBox();
            this.signatureTextBox = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // publicKeyLabel
            // 
            this.publicKeyLabel.Location = new System.Drawing.Point(33, 9);
            this.publicKeyLabel.Name = "publicKeyLabel";
            this.publicKeyLabel.Size = new System.Drawing.Size(100, 23);
            this.publicKeyLabel.TabIndex = 0;
            this.publicKeyLabel.Text = "Public Key";
            // 
            // nLabel
            // 
            this.nLabel.Location = new System.Drawing.Point(12, 32);
            this.nLabel.Name = "nLabel";
            this.nLabel.Size = new System.Drawing.Size(25, 21);
            this.nLabel.TabIndex = 3;
            this.nLabel.Text = "n";
            // 
            // eLabel
            // 
            this.eLabel.Location = new System.Drawing.Point(12, 95);
            this.eLabel.Name = "eLabel";
            this.eLabel.Size = new System.Drawing.Size(25, 23);
            this.eLabel.TabIndex = 4;
            this.eLabel.Text = "e";
            // 
            // digitalSignLabel
            // 
            this.digitalSignLabel.Location = new System.Drawing.Point(31, 168);
            this.digitalSignLabel.Name = "digitalSignLabel";
            this.digitalSignLabel.Size = new System.Drawing.Size(146, 23);
            this.digitalSignLabel.TabIndex = 5;
            this.digitalSignLabel.Text = "Digital Signature";
            // 
            // messageLabel
            // 
            this.messageLabel.Location = new System.Drawing.Point(31, 309);
            this.messageLabel.Name = "messageLabel";
            this.messageLabel.Size = new System.Drawing.Size(100, 23);
            this.messageLabel.TabIndex = 7;
            this.messageLabel.Text = "Message";
            // 
            // messageTextBox
            // 
            this.messageTextBox.Enabled = false;
            this.messageTextBox.Location = new System.Drawing.Point(31, 335);
            this.messageTextBox.Name = "messageTextBox";
            this.messageTextBox.Size = new System.Drawing.Size(196, 147);
            this.messageTextBox.TabIndex = 8;
            this.messageTextBox.Text = "";
            // 
            // verifyButton
            // 
            this.verifyButton.Location = new System.Drawing.Point(59, 511);
            this.verifyButton.Name = "verifyButton";
            this.verifyButton.Size = new System.Drawing.Size(145, 38);
            this.verifyButton.TabIndex = 9;
            this.verifyButton.Text = "Verify";
            this.verifyButton.UseVisualStyleBackColor = true;
            this.verifyButton.Click += new System.EventHandler(this.verifyButton_Click);
            // 
            // verificationLabel
            // 
            this.verificationLabel.Location = new System.Drawing.Point(33, 485);
            this.verificationLabel.Name = "verificationLabel";
            this.verificationLabel.Size = new System.Drawing.Size(194, 23);
            this.verificationLabel.TabIndex = 10;
            // 
            // nTextBox
            // 
            this.nTextBox.Enabled = false;
            this.nTextBox.Location = new System.Drawing.Point(33, 35);
            this.nTextBox.Name = "nTextBox";
            this.nTextBox.Size = new System.Drawing.Size(194, 57);
            this.nTextBox.TabIndex = 11;
            this.nTextBox.Text = "";
            // 
            // eTextBox
            // 
            this.eTextBox.Enabled = false;
            this.eTextBox.Location = new System.Drawing.Point(33, 98);
            this.eTextBox.Name = "eTextBox";
            this.eTextBox.Size = new System.Drawing.Size(194, 57);
            this.eTextBox.TabIndex = 12;
            this.eTextBox.Text = "";
            // 
            // signatureTextBox
            // 
            this.signatureTextBox.Enabled = false;
            this.signatureTextBox.Location = new System.Drawing.Point(32, 193);
            this.signatureTextBox.Name = "signatureTextBox";
            this.signatureTextBox.Size = new System.Drawing.Size(195, 103);
            this.signatureTextBox.TabIndex = 13;
            this.signatureTextBox.Text = "";
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(239, 567);
            this.Controls.Add(this.signatureTextBox);
            this.Controls.Add(this.eTextBox);
            this.Controls.Add(this.nTextBox);
            this.Controls.Add(this.verificationLabel);
            this.Controls.Add(this.verifyButton);
            this.Controls.Add(this.messageTextBox);
            this.Controls.Add(this.messageLabel);
            this.Controls.Add(this.digitalSignLabel);
            this.Controls.Add(this.eLabel);
            this.Controls.Add(this.nLabel);
            this.Controls.Add(this.publicKeyLabel);
            this.Name = "MainWindow";
            this.Text = "MainWindow";
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.RichTextBox nTextBox;
        private System.Windows.Forms.RichTextBox eTextBox;
        private System.Windows.Forms.RichTextBox signatureTextBox;

        private System.Windows.Forms.Label messageLabel;
        private System.Windows.Forms.RichTextBox messageTextBox;
        private System.Windows.Forms.Button verifyButton;
        private System.Windows.Forms.Label verificationLabel;

        private System.Windows.Forms.Label digitalSignLabel;

        private System.Windows.Forms.Label publicKeyLabel;
        private System.Windows.Forms.Label nLabel;

        private System.Windows.Forms.Label eLabel;

        #endregion
    }
}