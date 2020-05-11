using BitcoinWallet_beta1._0_.Models;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.IO;

namespace BitcoinWallet_beta1._0_.Helpers
{
    public static class FileHelper
    {
        private static string _pathToWallet = @"D:\Wallet\wallet.json";
        static FileHelper()
        {
        }

        // write wallet info to json
        public static void WriteWalletToJson(WalletDto wallet)
        {
            List<WalletDto> _data = new List<WalletDto>();
            _data.Add(wallet);
            string json = JsonConvert.SerializeObject(_data.ToArray());
            File.WriteAllText(_pathToWallet, json);
        }

        // load already created wallet
        public static WalletDto LoadWalletFromJson()
        {
            bool fileExists = File.Exists(_pathToWallet);
            if (fileExists)
            {
                using (StreamReader r = new StreamReader(_pathToWallet))
                {
                    string json = r.ReadToEnd();
                    List<WalletDto> items = JsonConvert.DeserializeObject<List<WalletDto>>(json);

                    return items[0];
                }
            } else
            {
                return null;
            }
        }
    }
}
