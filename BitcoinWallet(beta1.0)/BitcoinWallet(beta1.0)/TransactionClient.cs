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
        public TransactionClient()
        {
            // create a client
            _client = new QBitNinjaClient(Network.TestNet);
        }

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

        public TransactionInfo GetTransactionInfo(string transactionId)
        {
            GetTransactionResponse transactionResponse = GetTransactionResponseObject(transactionId);

            List<ICoin> receivedCoins = transactionResponse.ReceivedCoins;
            TransactionInfo transactionInfo = new TransactionInfo();
            List<OutputInfo> outputsInfo = new List<OutputInfo>();

            // for each output in transaction receive coins amount, adress and payment script
            foreach (var coin in receivedCoins)
            {
                OutputInfo oi = new OutputInfo();

                // get bitcoins amount
                Money amount = (Money)coin.Amount;
                oi.bitcoinsAmount = amount.ToDecimal(MoneyUnit.BTC);

                // get payment script
                Script paymentScript = coin.TxOut.ScriptPubKey;
                oi.paymentScript = paymentScript;

                // get bitcoin adress
                var address = paymentScript.GetDestinationAddress(Network.TestNet);
                oi.adress = address;

                outputsInfo.Add(oi);
            }
            transactionInfo.outputsInfo = outputsInfo;

            return transactionInfo;
        }
    }
}
