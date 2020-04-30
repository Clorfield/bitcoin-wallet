using NBitcoin;

namespace BitcoinWallet_beta1._0_
{
    public class Wallet
    {
        public Wallet()
        {
            GenerateNewKey();
        }
        private Key _privateKey { get; set; }

        // generate a random private key
        public void GenerateNewKey()
        {
            Key privateKey = new Key();
            _privateKey = privateKey;
        }

        // get public key
        public PubKey GetPublicKey()
        {
            return _privateKey.PubKey;
        }

        // get bitcoin wallet test adress (with fake bitcoins)
        public BitcoinAddress GetBitcoinAdress()
        {
            PubKey publicKey = GetPublicKey();
            return publicKey.GetAddress(ScriptPubKeyType.Legacy, Network.TestNet);
        }
    }
}
