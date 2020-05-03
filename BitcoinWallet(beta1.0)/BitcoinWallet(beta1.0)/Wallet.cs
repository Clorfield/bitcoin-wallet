using BitcoinWallet_beta1._0_.Enums;
using NBitcoin;

namespace BitcoinWallet_beta1._0_
{
    public class Wallet
    {
        private Key _privateKey { get; set; }
        private Network _networkType { get; set; } = Network.TestNet;
        public Wallet()
        {
            GenerateNewKey();
        }

        // changing network type for wallet
        public void ChangeNetworkType(NetworkTypes networkType)
        {
            _networkType = networkType == NetworkTypes.TestNet ? Network.TestNet : Network.Main;
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

        // get bitcoin wallet adress
        public BitcoinAddress GetBitcoinAdress()
        {
            PubKey publicKey = GetPublicKey();
            return publicKey.GetAddress(ScriptPubKeyType.Legacy, _networkType);
        }

        // get public script key
        public Script GetScriptPubKey()
        {
            var publicKeyHash = new KeyId(GetPublicKey().ToString());
            var testNetAddress = publicKeyHash.GetAddress(_networkType);

            return testNetAddress.ScriptPubKey;
        }
    }
}
