using NBitcoin;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BitcoinWallet_beta1._0_
{
    public partial class MainWindow : Form
    {
        Wallet wallet = new Wallet();
        public MainWindow()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show(wallet.GetBitcoinAdress().ToString());
        }
    }
}
