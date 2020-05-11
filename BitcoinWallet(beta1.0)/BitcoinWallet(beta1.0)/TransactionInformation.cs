using BitcoinWallet_beta1._0_.Enums;
using BitcoinWallet_beta1._0_.Models;
using System.Windows.Forms;

namespace BitcoinWallet_beta1._0_
{
    public partial class TransactionInformation : Form
    {
        public TransactionInformation(TransactionInfo transactionInfo)
        {
            InitializeComponent();
            FillTransactionInformation(transactionInfo);
        }

        public void FillTransactionInformation(TransactionInfo transactionInfo)
        {
            string trType = transactionInfo.transactionType == TransactionActions.ReceiveCoins ? "Receiving" : "Spending";
            labelTransactionType.Text = $"Transaction type: {trType}";
            textBoxFee.Text = transactionInfo.TransactionFee?.ToString();

            foreach(OutputInfo outputInfo in transactionInfo.outputsInfo)
            {
                dataGridViewTrInfo.Rows.Add(outputInfo.bitcoinsAmount, outputInfo.paymentScript, outputInfo.adress);
            }
        }
    }
}
