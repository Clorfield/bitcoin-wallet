using BitcoinWallet_beta1._0_.Enums;
using BitcoinWallet_beta1._0_.Models;
using NBitcoin;
using QBitNinja.Client;
using QBitNinja.Client.Models;
using System;
using System.Collections.Generic;

namespace BitcoinWallet_beta1._0_
{
    public class TransactionClient
    {
        private QBitNinjaClient _client { get; set; }
        private Network _networkType { get; set; } = Network.TestNet;
        public TransactionClient()
        {
            // create a client
            _client = new QBitNinjaClient(Network.TestNet);
        }

        // changing network type for client
        public void ChangeNetworkType(NetworkTypes networkType)
        {
            _client = networkType == NetworkTypes.TestNet ? new QBitNinjaClient(Network.TestNet) : new QBitNinjaClient(Network.Main);
            _networkType = networkType == NetworkTypes.TestNet ? Network.TestNet : Network.Main;
        }

        // get transaction response object by transaction id
        public GetTransactionResponse GetTransactionResponseObject(string transactionId)
        {
            // parse transaction id to NBitcoin.uint256 so the client can eat it
            var parsedTransactionId = uint256.Parse(transactionId);
            // query the transaction
            GetTransactionResponse transactionResponse = _client.GetTransaction(parsedTransactionId).Result;
            // get transaction
            if (transactionResponse != null)
            {
                return transactionResponse;
            } else
            {
                throw new Exception("Can not get info for transaction with this ID or transaction does not exist.");
            }
        }

        // get transction information
        public TransactionInfo GetTransactionInfo(string transactionId, TransactionActions actionType)
        {
            GetTransactionResponse transactionResponse = GetTransactionResponseObject(transactionId);

            TransactionInfo transactionInfo = new TransactionInfo();
            switch (actionType)
            {
                case TransactionActions.ReceiveCoins:
                     List<ICoin> receivedCoins = transactionResponse.ReceivedCoins;
                     transactionInfo.TransactionFee = GetTransactionFee(transactionResponse.Transaction, receivedCoins);
                     transactionInfo.outputsInfo = GetInfoAboutCoins(receivedCoins);
                     break;
                case TransactionActions.SpendCoins:
                     List<ICoin> spentCoins = transactionResponse.SpentCoins;
                     transactionInfo.TransactionFee = GetTransactionFee(transactionResponse.Transaction, spentCoins);
                     transactionInfo.outputsInfo = GetInfoAboutCoins(spentCoins);
                     break;
            }

            return transactionInfo;
        }

        // get info about coins in each output in transaction response
        public List<OutputInfo> GetInfoAboutCoins(List<ICoin> coins)
        {
            List<OutputInfo> outputsInfo = new List<OutputInfo>();

            // for each output in transaction receive information
            foreach (var coin in coins)
            {
                OutputInfo oi = new OutputInfo();

                // get bitcoins amount
                Money amount = (Money)coin.Amount;
                oi.bitcoinsAmount = amount.ToDecimal(MoneyUnit.BTC);

                // get payment script
                Script paymentScript = coin.TxOut.ScriptPubKey;
                oi.paymentScript = paymentScript;

                // get bitcoin adress
                var address = paymentScript.GetDestinationAddress(_networkType);
                oi.adress = address;

                outputsInfo.Add(oi);
            }

            return outputsInfo;
        }

        // get transaction fee (returns fee amount if coins are spent and null if they are received
        public Money GetTransactionFee(Transaction transaction, List<ICoin> coins)
        {
            Money fee = transaction.GetFee(coins.ToArray());
            return fee;
        }
    }
}
