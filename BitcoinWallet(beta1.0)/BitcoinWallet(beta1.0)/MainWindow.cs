﻿using BitcoinWallet_beta1._0_.BL;
using BitcoinWallet_beta1._0_.Enums;
using BitcoinWallet_beta1._0_.Helpers;
using BitcoinWallet_beta1._0_.Models;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace BitcoinWallet_beta1._0_
{
    public partial class MainWindow : Form
    {
        private MoneyTransferBl _moneyTransferBl;

        public MainWindow()
        {
            _moneyTransferBl = new MoneyTransferBl(new Wallet(), new TransactionClient());

            InitializeComponent();
            WalletDto wallet = FileHelper.LoadWalletFromJson();
            if (wallet != null)
            {
                textBoxBitcoinAdress.Text = wallet.BitcoinAdress;
                textBoxPublicKey.Text = wallet.PublicKey;
                textBoxScriptPubKey.Text = wallet.ScriptPubKey;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            WalletView walletInfo = _moneyTransferBl.GetWalletInfoForGrid();
            textBoxBitcoinAdress.Text = walletInfo.BitcoinAdress;
            textBoxPublicKey.Text = walletInfo.PublicKey;
            textBoxScriptPubKey.Text = walletInfo.ScriptPubKey;

            WalletDto walletDto = new WalletDto(walletInfo.BitcoinAdress,
                                                walletInfo.PublicKey,
                                                walletInfo.ScriptPubKey);
            FileHelper.WriteWalletToJson(walletDto);
        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter && !string.IsNullOrEmpty(textBox1.Text.Trim()))
            {
                Currencies currency = radioBtnUAH.Checked ? Currencies.UAH : Currencies.BTC;
                OpenTransactionInfoWindow(currency);
            }
        }

        private void testNetBtn_CheckedChanged(object sender, EventArgs e)
        {
            _moneyTransferBl.ChangeNetworkType(NetworkTypes.TestNet);
        }

        private void mainNetBtn_CheckedChanged(object sender, EventArgs e)
        {
            _moneyTransferBl.ChangeNetworkType(NetworkTypes.Main);
        }

        private void buttonGetTransactionInfo_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(textBox1.Text.Trim()))
            {
                Currencies currency = radioBtnUAH.Checked ? Currencies.UAH : Currencies.BTC;
                OpenTransactionInfoWindow(currency);
            }
        }

        private void OpenTransactionInfoWindow(Currencies currency)
        {
            TransactionInfo transactionInfo = _moneyTransferBl._trClient.GetTransactionInfo(textBox1.Text, TransactionActions.ReceiveCoins);

            TransactionInformation transactionForm = new TransactionInformation(transactionInfo, currency);
            transactionForm.Show();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(textBox2.Text.Trim()) && textBox2.Text.Trim() != "Recipient adress" && !string.IsNullOrEmpty(textBox3.Text.Trim()))
            {
                CreateNewTransaction();
            }
        }

        private void CreateNewTransaction()
        {
            var currency = radioBtnUAH.Checked ? Currencies.UAH : Currencies.BTC;
            var coins = textBox3.Text;
            var senderAdress = textBoxBitcoinAdress.Text.Trim();
            var rcpAdress = textBox2.Text.Trim();
            var transactionResult = _moneyTransferBl.CreateNewTransaction(rcpAdress, senderAdress, coins, currency);

            switch(transactionResult)
            {
                case TransactionResult.NotEnoughMoney:
                    MessageBox.Show("You have not enought money for this transaction!");
                    break;
            }
            /*var publicKeyHash = new KeyId("c230422a436b50611f195ac70584611c9f227a75");

            var testNetAddress = publicKeyHash.GetAddress(Network.TestNet);
            //
            var transactionResponse = _moneyTransferBl._trClient.GetTransactionResponseObject("984d77987b4e7d9851883f5959975ffa4036ae5ac8d41ba488d01aa9887d0dab");
            _moneyTransferBl.CreateNewTransaction(transactionResponse, testNetAddress.ScriptPubKey);*/
        }

        // creating placeholder for bitcoin adress field
        private void textBox2_Enter(object sender, EventArgs e)
        {
            if (textBox2.Text == "Recipient adress")
            {
                textBox2.Text = "";
                textBox2.ForeColor = Color.Black;
            }
        }
        // creating placeholder for bitcoin adress field
        private void textBox2_Leave(object sender, EventArgs e)
        {
            if (textBox2.Text == "")
            {
                textBox2.Text = "Recipient adress";
                textBox2.ForeColor = Color.DarkGray;
            }
        }
        // creating placeholder for bitcoins amount field
        private void textBox3_Enter(object sender, EventArgs e)
        {
            if (textBox3.Text == "Bitcoins amount")
            {
                textBox3.Text = "";
                textBox3.ForeColor = Color.Black;
            }
        }
        // creating placeholder for bitcoins amount field
        private void textBox3_Leave(object sender, EventArgs e)
        {
            if (textBox3.Text == "")
            {
                textBox3.Text = "Bitcoins amount";
                textBox3.ForeColor = Color.DarkGray;
            }
        }

        // create a decimal only mask for bitcoins amount field
        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        // get balance
        private void button2_Click(object sender, EventArgs e)
        {
            string adress = textBoxBitcoinAdress.Text.Trim();
            if (!String.IsNullOrEmpty(adress))
            {
                decimal ballance = _moneyTransferBl.GetCustomBallance(adress);
                string currency = radioBtnUAH.Checked ? "UAH" : "BTC";
                if (radioBtnUAH.Checked)
                {
                    ballance = _moneyTransferBl.ConvertBitcoinToUAH(ballance);
                }
                MessageBox.Show($"Your balance: {ballance.ToString()} {currency}");
            } else
            {
                MessageBox.Show($"Please type adress in adress field!");
            }
            /*WebAPIHelper.Run(APIUrls.TestNetBitcoinAPIUrl);

            var a = Task.Run(() => WebAPIHelper.GetAsync<AdressInfoResponse>(APIUrls.GetAdressInfoAPI(textBoxBitcoinAdress.Text.Trim()))).GetAwaiter().GetResult();
            
            MessageBox.Show(a.ToString());*/
        }

        // show QRCode for typed adress
        private void qrCodeBtn_Click(object sender, EventArgs e)
        {
            var adress = textBoxBitcoinAdress.Text.Trim();
            if (!String.IsNullOrEmpty(adress)) {
                var qrCodeImage = QRCodeHelper.GenerateQRCodeFromAdress(adress);
                QRCodeForm qrCodeForm = new QRCodeForm(qrCodeImage);
                qrCodeForm.Show();
            }
        }

        private void radioBtnBTC_CheckedChanged(object sender, EventArgs e)
        {
            lblCurrency.Text = "BTC";
        }

        private void radioBtnUAH_CheckedChanged(object sender, EventArgs e)
        {
            lblCurrency.Text = "UAH";
        }
    }
}
