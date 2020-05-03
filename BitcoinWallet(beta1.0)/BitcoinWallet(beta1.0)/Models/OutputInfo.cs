using NBitcoin;

namespace BitcoinWallet_beta1._0_.Models
{
    public class OutputInfo
    {
        public decimal bitcoinsAmount { get; set; }
        public Script paymentScript { get; set; }
        public BitcoinAddress adress { get; set; }
    }
}
