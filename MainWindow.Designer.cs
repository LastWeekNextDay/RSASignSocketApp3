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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.nLabel = new System.Windows.Forms.Label();
            this.eLabel = new System.Windows.Forms.Label();
            this.digitalSignLabel = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.messageLabel = new System.Windows.Forms.Label();
            this.messageTextBox = new System.Windows.Forms.RichTextBox();
            this.verifyButton = new System.Windows.Forms.Button();
            this.verificationLabel = new System.Windows.Forms.Label();
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
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(33, 35);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(144, 22);
            this.textBox1.TabIndex = 1;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(32, 63);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(145, 22);
            this.textBox2.TabIndex = 2;
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
            this.eLabel.Location = new System.Drawing.Point(12, 60);
            this.eLabel.Name = "eLabel";
            this.eLabel.Size = new System.Drawing.Size(25, 23);
            this.eLabel.TabIndex = 4;
            this.eLabel.Text = "e";
            // 
            // digitalSignLabel
            // 
            this.digitalSignLabel.Location = new System.Drawing.Point(32, 118);
            this.digitalSignLabel.Name = "digitalSignLabel";
            this.digitalSignLabel.Size = new System.Drawing.Size(146, 23);
            this.digitalSignLabel.TabIndex = 5;
            this.digitalSignLabel.Text = "Digital Signature";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(33, 144);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(144, 22);
            this.textBox3.TabIndex = 6;
            // 
            // messageLabel
            // 
            this.messageLabel.Location = new System.Drawing.Point(32, 190);
            this.messageLabel.Name = "messageLabel";
            this.messageLabel.Size = new System.Drawing.Size(100, 23);
            this.messageLabel.TabIndex = 7;
            this.messageLabel.Text = "Message";
            // 
            // messageTextBox
            // 
            this.messageTextBox.Location = new System.Drawing.Point(32, 216);
            this.messageTextBox.Name = "messageTextBox";
            this.messageTextBox.Size = new System.Drawing.Size(146, 147);
            this.messageTextBox.TabIndex = 8;
            this.messageTextBox.Text = "";
            // 
            // verifyButton
            // 
            this.verifyButton.Location = new System.Drawing.Point(32, 392);
            this.verifyButton.Name = "verifyButton";
            this.verifyButton.Size = new System.Drawing.Size(145, 38);
            this.verifyButton.TabIndex = 9;
            this.verifyButton.Text = "Verify";
            this.verifyButton.UseVisualStyleBackColor = true;
            // 
            // verificationLabel
            // 
            this.verificationLabel.Location = new System.Drawing.Point(32, 366);
            this.verificationLabel.Name = "verificationLabel";
            this.verificationLabel.Size = new System.Drawing.Size(145, 23);
            this.verificationLabel.TabIndex = 10;
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(239, 451);
            this.Controls.Add(this.verificationLabel);
            this.Controls.Add(this.verifyButton);
            this.Controls.Add(this.messageTextBox);
            this.Controls.Add(this.messageLabel);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.digitalSignLabel);
            this.Controls.Add(this.eLabel);
            this.Controls.Add(this.nLabel);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.publicKeyLabel);
            this.Name = "MainWindow";
            this.Text = "MainWindow";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Label messageLabel;
        private System.Windows.Forms.RichTextBox messageTextBox;
        private System.Windows.Forms.Button verifyButton;
        private System.Windows.Forms.Label verificationLabel;

        private System.Windows.Forms.Label digitalSignLabel;
        private System.Windows.Forms.TextBox textBox3;

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label publicKeyLabel;
        private System.Windows.Forms.Label nLabel;

        private System.Windows.Forms.Label eLabel;

        #endregion
    }
}