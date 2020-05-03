using BitcoinWallet_beta1._0_.Enums;
using BitcoinWallet_beta1._0_.Interfaces;
using System.Linq;

namespace BitcoinWallet_beta1._0_.BL
{
    public class MoneyTransferBl: IMoneyTransferBl
    {
        public Wallet _wallet { get; set; }
        public TransactionClient _trClient { get; set; }

        public MoneyTransferBl(Wallet wallet, TransactionClient trClient)
        {
            _wallet = wallet;
            _trClient = trClient;
        }

        public void ChangeNetworkType(NetworkTypes networkType)
        {
            _trClient.ChangeNetworkType(networkType);
            _wallet.ChangeNetworkType(networkType);
        }

        public string test_GetParsedTransactionInfo(string transactionId)
        {
            var transactionInfo = _trClient.GetTransactionInfo(transactionId, TransactionActions.ReceiveCoins);
            var text = "";
            for (int i = 0; i < transactionInfo.outputsInfo.Count(); i++)
            {
                text+=  $"Output {i + 1}:\n" +
                        $"Coins passed by transaction: {transactionInfo.outputsInfo[i].bitcoinsAmount}\n" +
                        $"Adress: {transactionInfo.outputsInfo[i].adress}\n" +
                        $"\n\n";
            }
            text += $"Fee {transactionInfo.TransactionFee}:\n";

            return text;
        }

        public string test_GetParsedWalletInfo()
        {
            var text =  $"Bitcoin Adress: {_wallet.GetBitcoinAdress().ToString()}\n" +
                        $"Public Key: {_wallet.GetPublicKey()}\n" +
                        $"Script Public Key: {_wallet.GetScriptPubKey()}" +
                        $"\n\n";

            return text;
        }
    }
}
