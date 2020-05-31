using BitcoinWallet_beta1._0_.Enums;
using BitcoinWallet_beta1._0_.Models;
using NBitcoin;

namespace BitcoinWallet_beta1._0_.Interfaces
{
    public interface IMoneyTransferBl
    {
        void ChangeNetworkType(NetworkTypes networkType);
        TransactionResult CreateNewTransaction(string recepientAdress, string senderAdress, string bitcoinsAmount, Currencies currency);
        BitcoinAddress GetRecepientAdress(string recepientAdress);
        WalletView GetWalletInfoForGrid();
        decimal GetCurrentBallance();
        decimal GetCustomBallance(string adressString);
    }
}
