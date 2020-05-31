using BitcoinWallet_beta1._0_;
using BitcoinWallet_beta1._0_.BL;
using NUnit.Framework;

namespace BitcoinWalletTests
{
    [TestFixture]
    public class MoneyTransferTests
    {
        public MoneyTransferBl _moneyTransferBl { get; set; } = new MoneyTransferBl(new Wallet(), new TransactionClient());

        [TestCase("mqrGnuB5rZbQVRANFY72Qp5q5TgFyCQ5Y9")]
        public void GetBallanceTest(string adress)
        {
            decimal ballance = _moneyTransferBl.GetCustomBallance(adress);

            Assert.AreEqual(ballance, 0.001);
        }
    }
}
