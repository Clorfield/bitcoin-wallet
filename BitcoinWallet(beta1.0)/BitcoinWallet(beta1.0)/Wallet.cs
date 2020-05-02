using NBitcoin;

namespace BitcoinWallet_beta1._0_
{
    public class Wallet
    {
        private Key _privateKey { get; set; }
        public Wallet()
        {
            GenerateNewKey();
        }

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

        // get bitcoin wallet test adress (with fake bitcoins)
        public Script GetScriptPubKey()
        {
            var publicKeyHash = new KeyId(GetPublicKey().ToString());
            var testNetAddress = publicKeyHash.GetAddress(Network.TestNet);

            return testNetAddress.ScriptPubKey;
        }
    }
}
