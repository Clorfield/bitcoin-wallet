using BitcoinWallet_beta1._0_.BL;
using BitcoinWallet_beta1._0_.Enums;
using BitcoinWallet_beta1._0_.Models;
using System.Windows.Forms;

namespace BitcoinWallet_beta1._0_
{
    public partial class TransactionInformation : Form
    {
        private MoneyTransferBl _moneyTransferBl;
        private Currencies _currency { get; set; }
        public TransactionInformation(TransactionInfo transactionInfo, Currencies currency)
        {
            _moneyTransferBl = new MoneyTransferBl(new Wallet(), new TransactionClient());
            _currency = currency;
            InitializeComponent();
            FillTransactionInformation(transactionInfo);
        }

        public void FillTransactionInformation(TransactionInfo transactionInfo)
        {
            string trType = transactionInfo.transactionType == TransactionActions.ReceiveCoins ? "Receiving" : "Spending";
            labelTransactionType.Text = $"Transaction type: {trType}";
            textBoxFee.Text = transactionInfo.TransactionFee?.ToString();

            var convertBTCToUAH = _currency == Currencies.UAH;
            dataGridViewTrInfo.Columns[0].HeaderCell.Value += convertBTCToUAH ? " (UAH)" : " (BTC)";

            foreach (OutputInfo outputInfo in transactionInfo.outputsInfo)
            {
                outputInfo.bitcoinsAmount = convertBTCToUAH ? _moneyTransferBl.ConvertBitcoinToUAH(outputInfo.bitcoinsAmount) : outputInfo.bitcoinsAmount;

                dataGridViewTrInfo.Rows.Add(outputInfo.bitcoinsAmount, outputInfo.paymentScript, outputInfo.adress);
            }
        }
    }
}
