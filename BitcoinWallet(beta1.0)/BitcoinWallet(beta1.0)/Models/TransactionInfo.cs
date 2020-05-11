using BitcoinWallet_beta1._0_.Enums;
using NBitcoin;
using System.Collections.Generic;

namespace BitcoinWallet_beta1._0_.Models
{
    public class TransactionInfo
    {
        public List<OutputInfo> outputsInfo { get; set; }
        public Money TransactionFee { get; set; }
        public TransactionActions transactionType { get; set; }
    }
}
