using System.Drawing;
using System.Windows.Forms;

namespace BitcoinWallet_beta1._0_
{
    public partial class QRCodeForm : Form
    {
        public QRCodeForm(Image qrCodeImage)
        {
            InitializeComponent();

            qrCodePctBox.Image = qrCodeImage;
        }
    }
}
