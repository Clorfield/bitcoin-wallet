using BitcoinWallet_beta1._0_.Enums;
using BitcoinWallet_beta1._0_.Interfaces;
using BitcoinWallet_beta1._0_.Models;
using NBitcoin;
using QBitNinja.Client.Models;
using System;
using System.Globalization;
using System.Linq;

namespace BitcoinWallet_beta1._0_.BL
{
    public class MoneyTransferBl: IMoneyTransferBl
    {
        public Wallet _wallet { get; set; }
        public TransactionClient _trClient { get; set; }
        private Network _networkType { get; set; } = Network.TestNet;

        public MoneyTransferBl(Wallet wallet, TransactionClient trClient)
        {
            _wallet = wallet;
            _trClient = trClient;
        }

        // change network type
        public void ChangeNetworkType(NetworkTypes networkType)
        {
            _trClient.ChangeNetworkType(networkType);
            _wallet.ChangeNetworkType(networkType);
            _networkType = networkType == NetworkTypes.TestNet ? Network.TestNet : Network.Main;
        }

        //// create new transaction for bitcoin sending
        //public void CreateNewTransaction(GetTransactionResponse transactionResponse, Script scriptPubKey, string recepientAdress)
        //{
        //    BitcoinAddress rcpAdress = GetRecepientAdress(recepientAdress);

        //    // get all coins received by current transaction
        //    var receivedCoins = transactionResponse.ReceivedCoins;
        //    OutPoint outPointToSpend = null;
        //    foreach (var coin in receivedCoins)
        //    {
        //        if (coin.TxOut.ScriptPubKey == scriptPubKey)
        //        {
        //            outPointToSpend = coin.Outpoint;
        //        }
        //    }
        //    if (outPointToSpend == null)
        //    {
        //        throw new Exception("TxOut doesn't contain our ScriptPubKey");
        //    }
        //    //Console.WriteLine("We want to spend {0}. outpoint:", outPointToSpend.N + 1);
        //    var transaction = Transaction.Create(_networkType);
        //    transaction.Inputs.Add(new TxIn()
        //    {
        //        PrevOut = outPointToSpend
        //    });
        //}

        // create new transaction 
        public TransactionResult CreateNewTransaction(string recepientAdress, string bitcoinsAmount)
        {
            BitcoinAddress rcpAdress = GetRecepientAdress(recepientAdress);
            Money coins = new Money(Decimal.Parse(bitcoinsAmount, CultureInfo.InvariantCulture), MoneyUnit.BTC);
            var enoughMoney = _trClient.HasEnoughCoins(coins, rcpAdress);

            if (!enoughMoney)
            {
                return TransactionResult.NotEnoughMoney;
            }

            return TransactionResult.Success;
        }

        // create recepient adress
        public BitcoinAddress GetRecepientAdress(string recepientAdress)
        {
            return BitcoinAddress.Create(recepientAdress, _networkType);
        }

        // get information about wallet for grid view
        public WalletView GetWalletInfoForGrid()
        {
            WalletView walletInfo = new WalletView();
            walletInfo.BitcoinAdress = _wallet.GetBitcoinAdress().ToString();
            walletInfo.PublicKey = _wallet.GetPublicKey().ToString();
            walletInfo.ScriptPubKey = _wallet.GetScriptPubKey().ToString();

            return walletInfo;
        }

        // get ballance for current bitcoin adress
        public decimal GetCurrentBallance()
        {
            BitcoinAddress adress = _wallet.GetBitcoinAdress();
            var balance = _trClient.GetBallance(adress);

            return balance;
        }

        // get ballance for any bitcoin adress
        public decimal GetCustomBallance(string adressString)
        {
            BitcoinAddress adress = GetRecepientAdress(adressString);
            var balance = _trClient.GetBallance(adress);

            return balance;
        }


    }
}
