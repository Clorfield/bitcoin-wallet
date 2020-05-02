using System;
using System.Linq;
using System.Windows.Forms;

namespace BitcoinWallet_beta1._0_
{
    public partial class MainWindow : Form
    {
        Wallet wallet = new Wallet();
        TransactionClient trClient = new TransactionClient();
 
        public MainWindow()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = $"Bitcoin Adress: {wallet.GetBitcoinAdress().ToString()}\n" +
                                $"Public Key: {wallet.GetPublicKey()}\n" +
                                $"Script Public Key: {wallet.GetScriptPubKey()}" +
                                $"\n\n";
        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter && !string.IsNullOrEmpty(textBox1.Text))
            {
                var transactionInfo = trClient.GetTransactionInfo(textBox1.Text);

                for(int i = 0; i < transactionInfo.outputsInfo.Count(); i++)
                {
                    richTextBox1.Text += $"Output {i+1}:\n" +
                                         $"Coins passed by transaction: {transactionInfo.outputsInfo[i].bitcoinsAmount}\n" +
                                         $"Adress: {transactionInfo.outputsInfo[i].adress}\n" +
                                         $"\n\n";
                }
            }
        }
    }
}
