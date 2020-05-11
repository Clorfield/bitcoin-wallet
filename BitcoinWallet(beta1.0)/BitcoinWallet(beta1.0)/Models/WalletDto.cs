namespace BitcoinWallet_beta1._0_.Models
{
    public class WalletDto
    {
        public WalletDto(string bitcoinAdress, string publicKey, string scriptPubKey)
        {
            BitcoinAdress = bitcoinAdress;
            PublicKey = publicKey;
            ScriptPubKey = scriptPubKey;
        }
        public string BitcoinAdress { get; set; }
        public string PublicKey { get; set; }
        public string ScriptPubKey { get; set; }
    }
}
