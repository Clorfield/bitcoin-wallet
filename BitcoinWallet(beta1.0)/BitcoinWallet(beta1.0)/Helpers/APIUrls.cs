namespace BitcoinWallet_beta1._0_.Helpers
{
    static public class APIUrls
    {
        static public string TestNetBitcoinAPIUrl = "https://testnet-api.smartbit.com.au/v1/blockchain/";

        static public string GetAdressInfoAPI(string adress)
        {
            return $"address/{adress}/unspent";
        }
    }
}
