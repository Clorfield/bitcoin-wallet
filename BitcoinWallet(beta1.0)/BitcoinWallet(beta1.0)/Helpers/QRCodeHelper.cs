using System.Drawing;
using Zen.Barcode;

namespace BitcoinWallet_beta1._0_.Helpers
{
    static public class QRCodeHelper
    {
        // create QRCode from string
        static public Image GenerateQRCodeFromAdress(string row)
        {
            CodeQrBarcodeDraw qrCode = BarcodeDrawFactory.CodeQr;
            return qrCode.Draw(row, 200);
        }
    }
}
