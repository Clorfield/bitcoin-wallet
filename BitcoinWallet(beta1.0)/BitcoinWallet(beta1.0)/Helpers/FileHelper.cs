using BitcoinWallet_beta1._0_.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.InteropServices;
using System.Security.Cryptography;

namespace BitcoinWallet_beta1._0_.Helpers
{
    public static class FileHelper
    {
        private const int SaltSize = 8;
        private const string PathToWallet = @"D:\Wallet\wallet.json";

        static FileHelper()
        {
        }

        // write wallet info to json
        public static void WriteWalletToJson(WalletDto wallet)
        {
            DeleteFile(PathToWallet + ".aes");

            List<WalletDto> _data = new List<WalletDto>();
            _data.Add(wallet);
            string json = JsonConvert.SerializeObject(_data.ToArray());
            File.WriteAllText(PathToWallet, json);

            string password = "health-bells";

            // For additional security Pin the password of your files
            GCHandle gch = GCHandle.Alloc(password, GCHandleType.Pinned);

            // Encrypt the file
            AESEncryptionHelper.FileEncrypt(PathToWallet, password);

            // To increase the security of the encryption, delete the given password from the memory !
            AESEncryptionHelper.ZeroMemory(gch.AddrOfPinnedObject(), password.Length * 2);
            gch.Free();

            DeleteFile(PathToWallet);
        }

        // load already created wallet
        public static WalletDto LoadWalletFromJson()
        {
            bool fileExists = File.Exists(PathToWallet + ".aes");
            if (fileExists)
            {
                string password = "health-bells";

                // For additional security Pin the password of your files
                GCHandle gch = GCHandle.Alloc(password, GCHandleType.Pinned);

                // Decrypt the file
                AESEncryptionHelper.FileDecrypt(PathToWallet + ".aes", PathToWallet, password);

                // To increase the security of the decryption, delete the used password from the memory !
                AESEncryptionHelper.ZeroMemory(gch.AddrOfPinnedObject(), password.Length * 2);
                gch.Free();


                using (StreamReader r = new StreamReader(PathToWallet))
                {
                    string json = r.ReadToEnd();
                    List<WalletDto> items = JsonConvert.DeserializeObject<List<WalletDto>>(json);

                    r.Close();
                    DeleteFile(PathToWallet);
                    return items[0];
                }
            } else
            {
                return null;
            }
        }

        public static void DeleteFile(string path)
        {
            if (File.Exists(path))
            {
                File.Delete(path);
            }
        }
    }
}
