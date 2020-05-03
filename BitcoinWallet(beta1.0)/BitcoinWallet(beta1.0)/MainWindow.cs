using BitcoinWallet_beta1._0_.BL;
using BitcoinWallet_beta1._0_.Enums;
using System;
using System.Windows.Forms;

namespace BitcoinWallet_beta1._0_
{
    public partial class MainWindow : Form
    {
        MoneyTransferBl _moneyTransferBl;

        public MainWindow()
        {
            _moneyTransferBl = new MoneyTransferBl(new Wallet(), new TransactionClient());

            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = _moneyTransferBl.test_GetParsedWalletInfo();
        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter && !string.IsNullOrEmpty(textBox1.Text))
            {
                string transactionInfo = _moneyTransferBl.test_GetParsedTransactionInfo(textBox1.Text);
                richTextBox1.Text = transactionInfo;
            }
        }

        private void testNetBtn_CheckedChanged(object sender, EventArgs e)
        {
            _moneyTransferBl.ChangeNetworkType(NetworkTypes.TestNet);
        }

        private void mainNetBtn_CheckedChanged(object sender, EventArgs e)
        {
            _moneyTransferBl.ChangeNetworkType(NetworkTypes.Main);
        }
    }
}
