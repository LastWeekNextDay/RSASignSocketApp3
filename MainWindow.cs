using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using RSASignatureApplication2;

namespace RSASignatureApplication3
{
    public partial class MainWindow : Form
    {
        private readonly SocketInteractor _socketInteractor;
        public MainWindow()
        {
            _socketInteractor = new SocketInteractor();
            _socketInteractor.Connect();
            var socketT = new Thread(async () =>
            {
                while (true)
                {
                    await _socketInteractor.Listen();
                }
            });
            var t = new Thread(new ThreadStart(CheckChangeLoop));
            t.Start();
            socketT.Start();
            InitializeComponent();
        }
        
        private void InvokeUI(Action action)
        {
            BeginInvoke(new MethodInvoker(action));
        }

        private void CheckChangeLoop()
        {
            while (true)
            {
                if (_socketInteractor.Change != 1) continue;
                _socketInteractor.Change = 0;
                InvokeUI(() =>
                {
                    var dialogResult = MessageBox.Show($"New message incoming. Do you wish to accept?", 
                        "Incoming.", MessageBoxButtons.YesNo);
                    if (dialogResult != DialogResult.Yes) return;
                    var data = _socketInteractor.Data.Split(new string[] { "~|~" }, StringSplitOptions.None);
                    var message = data[1];
                    var signature = data[2];
                    var modulus = data[3];
                    var exponent = data[4];

                    messageTextBox.Text = message;
                    signatureTextBox.Text = signature;
                    nTextBox.Text = modulus;
                    eTextBox.Text = exponent;
                });
            }
        }

        private void verifyButton_Click(object sender, EventArgs e)
        {
            var message = messageTextBox.Text;
            var signature = signatureTextBox.Text;
            var modulus = nTextBox.Text;
            var exponent = eTextBox.Text;
            var rsa = new RSACryptoServiceProvider();
            var rsaKey = new RSAParameters
            {
                Modulus = Convert.FromBase64String(modulus),
                Exponent = Convert.FromBase64String(exponent)
            };
            rsa.ImportParameters(rsaKey);
            var data = Encoding.ASCII.GetBytes(message);
            var verified = rsa.VerifyData(data, SHA256.Create(), Convert.FromBase64String(signature));
            MessageBox.Show(verified ? "Message authentic." : "Message not authentic.");
        }
    }
}