namespace BitcoinWallet_beta1._0_
{
    partial class MainWindow
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxBitcoinAdress = new System.Windows.Forms.TextBox();
            this.textBoxPublicKey = new System.Windows.Forms.TextBox();
            this.textBoxScriptPubKey = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.buttonGetTransactionInfo = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.buttonCreateTransaction = new System.Windows.Forms.Button();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.qrCodeBtn = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioBtnUAH = new System.Windows.Forms.RadioButton();
            this.radioBtnBTC = new System.Windows.Forms.RadioButton();
            this.mainNetBtn = new System.Windows.Forms.RadioButton();
            this.testNetBtn = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lblCurrency = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(434, 273);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(115, 46);
            this.button1.TabIndex = 0;
            this.button1.Text = "Generate New Key";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(15, 210);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(337, 20);
            this.textBox1.TabIndex = 2;
            this.textBox1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox1_KeyDown);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 194);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Get transaction info";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 20);
            this.label4.TabIndex = 9;
            this.label4.Text = "Adress info";
            // 
            // textBoxBitcoinAdress
            // 
            this.textBoxBitcoinAdress.Location = new System.Drawing.Point(15, 50);
            this.textBoxBitcoinAdress.Name = "textBoxBitcoinAdress";
            this.textBoxBitcoinAdress.Size = new System.Drawing.Size(337, 20);
            this.textBoxBitcoinAdress.TabIndex = 11;
            // 
            // textBoxPublicKey
            // 
            this.textBoxPublicKey.Location = new System.Drawing.Point(15, 92);
            this.textBoxPublicKey.Name = "textBoxPublicKey";
            this.textBoxPublicKey.ReadOnly = true;
            this.textBoxPublicKey.Size = new System.Drawing.Size(337, 20);
            this.textBoxPublicKey.TabIndex = 12;
            // 
            // textBoxScriptPubKey
            // 
            this.textBoxScriptPubKey.Location = new System.Drawing.Point(15, 132);
            this.textBoxScriptPubKey.Name = "textBoxScriptPubKey";
            this.textBoxScriptPubKey.ReadOnly = true;
            this.textBoxScriptPubKey.Size = new System.Drawing.Size(337, 20);
            this.textBoxScriptPubKey.TabIndex = 13;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 36);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(74, 13);
            this.label5.TabIndex = 14;
            this.label5.Text = "Bitcoin Adress";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 76);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(57, 13);
            this.label6.TabIndex = 15;
            this.label6.Text = "Public Key";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 116);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(71, 13);
            this.label7.TabIndex = 16;
            this.label7.Text = "ScriptPubKey";
            // 
            // buttonGetTransactionInfo
            // 
            this.buttonGetTransactionInfo.Location = new System.Drawing.Point(358, 209);
            this.buttonGetTransactionInfo.Name = "buttonGetTransactionInfo";
            this.buttonGetTransactionInfo.Size = new System.Drawing.Size(55, 20);
            this.buttonGetTransactionInfo.TabIndex = 17;
            this.buttonGetTransactionInfo.Text = "Get";
            this.buttonGetTransactionInfo.UseVisualStyleBackColor = true;
            this.buttonGetTransactionInfo.Click += new System.EventHandler(this.buttonGetTransactionInfo_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 262);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Create transaction";
            // 
            // textBox2
            // 
            this.textBox2.ForeColor = System.Drawing.Color.DarkGray;
            this.textBox2.Location = new System.Drawing.Point(16, 278);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(132, 20);
            this.textBox2.TabIndex = 6;
            this.textBox2.Text = "Recipient adress";
            this.textBox2.Enter += new System.EventHandler(this.textBox2_Enter);
            this.textBox2.Leave += new System.EventHandler(this.textBox2_Leave);
            // 
            // buttonCreateTransaction
            // 
            this.buttonCreateTransaction.Location = new System.Drawing.Point(358, 277);
            this.buttonCreateTransaction.Name = "buttonCreateTransaction";
            this.buttonCreateTransaction.Size = new System.Drawing.Size(58, 21);
            this.buttonCreateTransaction.TabIndex = 18;
            this.buttonCreateTransaction.Text = "Create";
            this.buttonCreateTransaction.UseVisualStyleBackColor = true;
            this.buttonCreateTransaction.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // textBox3
            // 
            this.textBox3.ForeColor = System.Drawing.Color.DarkGray;
            this.textBox3.Location = new System.Drawing.Point(171, 278);
            this.textBox3.MaxLength = 30;
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(137, 20);
            this.textBox3.TabIndex = 19;
            this.textBox3.Text = "Bitcoins amount";
            this.textBox3.Enter += new System.EventHandler(this.textBox3_Enter);
            this.textBox3.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox3_KeyPress);
            this.textBox3.Leave += new System.EventHandler(this.textBox3_Leave);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(434, 209);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(115, 49);
            this.button2.TabIndex = 20;
            this.button2.Text = "Balance";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // qrCodeBtn
            // 
            this.qrCodeBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.qrCodeBtn.Location = new System.Drawing.Point(358, 50);
            this.qrCodeBtn.Name = "qrCodeBtn";
            this.qrCodeBtn.Size = new System.Drawing.Size(55, 20);
            this.qrCodeBtn.TabIndex = 21;
            this.qrCodeBtn.Text = "QRCode";
            this.qrCodeBtn.UseVisualStyleBackColor = true;
            this.qrCodeBtn.Click += new System.EventHandler(this.qrCodeBtn_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioBtnUAH);
            this.groupBox1.Controls.Add(this.radioBtnBTC);
            this.groupBox1.Location = new System.Drawing.Point(434, 132);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(115, 71);
            this.groupBox1.TabIndex = 22;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Currency";
            // 
            // radioBtnUAH
            // 
            this.radioBtnUAH.AutoSize = true;
            this.radioBtnUAH.Location = new System.Drawing.Point(20, 44);
            this.radioBtnUAH.Name = "radioBtnUAH";
            this.radioBtnUAH.Size = new System.Drawing.Size(48, 17);
            this.radioBtnUAH.TabIndex = 1;
            this.radioBtnUAH.Text = "UAH";
            this.radioBtnUAH.UseVisualStyleBackColor = true;
            this.radioBtnUAH.CheckedChanged += new System.EventHandler(this.radioBtnUAH_CheckedChanged);
            // 
            // radioBtnBTC
            // 
            this.radioBtnBTC.AutoSize = true;
            this.radioBtnBTC.Checked = true;
            this.radioBtnBTC.Location = new System.Drawing.Point(20, 20);
            this.radioBtnBTC.Name = "radioBtnBTC";
            this.radioBtnBTC.Size = new System.Drawing.Size(46, 17);
            this.radioBtnBTC.TabIndex = 0;
            this.radioBtnBTC.TabStop = true;
            this.radioBtnBTC.Text = "BTC";
            this.radioBtnBTC.UseVisualStyleBackColor = true;
            this.radioBtnBTC.CheckedChanged += new System.EventHandler(this.radioBtnBTC_CheckedChanged);
            // 
            // mainNetBtn
            // 
            this.mainNetBtn.AutoSize = true;
            this.mainNetBtn.Location = new System.Drawing.Point(5, 44);
            this.mainNetBtn.Name = "mainNetBtn";
            this.mainNetBtn.Size = new System.Drawing.Size(65, 17);
            this.mainNetBtn.TabIndex = 4;
            this.mainNetBtn.TabStop = true;
            this.mainNetBtn.Text = "MainNet";
            this.mainNetBtn.UseVisualStyleBackColor = true;
            this.mainNetBtn.CheckedChanged += new System.EventHandler(this.mainNetBtn_CheckedChanged);
            // 
            // testNetBtn
            // 
            this.testNetBtn.AutoSize = true;
            this.testNetBtn.Checked = true;
            this.testNetBtn.Location = new System.Drawing.Point(5, 21);
            this.testNetBtn.Name = "testNetBtn";
            this.testNetBtn.Size = new System.Drawing.Size(63, 17);
            this.testNetBtn.TabIndex = 3;
            this.testNetBtn.TabStop = true;
            this.testNetBtn.Text = "TestNet";
            this.testNetBtn.UseVisualStyleBackColor = true;
            this.testNetBtn.CheckedChanged += new System.EventHandler(this.testNetBtn_CheckedChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.mainNetBtn);
            this.groupBox2.Controls.Add(this.testNetBtn);
            this.groupBox2.Location = new System.Drawing.Point(475, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(74, 79);
            this.groupBox2.TabIndex = 23;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Network";
            // 
            // lblCurrency
            // 
            this.lblCurrency.AutoSize = true;
            this.lblCurrency.Location = new System.Drawing.Point(314, 281);
            this.lblCurrency.Name = "lblCurrency";
            this.lblCurrency.Size = new System.Drawing.Size(28, 13);
            this.lblCurrency.TabIndex = 24;
            this.lblCurrency.Text = "BTC";
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(567, 332);
            this.Controls.Add(this.lblCurrency);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.qrCodeBtn);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.buttonCreateTransaction);
            this.Controls.Add(this.buttonGetTransactionInfo);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBoxScriptPubKey);
            this.Controls.Add(this.textBoxPublicKey);
            this.Controls.Add(this.textBoxBitcoinAdress);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "MainWindow";
            this.Text = "Bitcoin-wallet";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxBitcoinAdress;
        private System.Windows.Forms.TextBox textBoxPublicKey;
        private System.Windows.Forms.TextBox textBoxScriptPubKey;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button buttonGetTransactionInfo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button buttonCreateTransaction;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button qrCodeBtn;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioBtnUAH;
        private System.Windows.Forms.RadioButton radioBtnBTC;
        private System.Windows.Forms.RadioButton mainNetBtn;
        private System.Windows.Forms.RadioButton testNetBtn;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lblCurrency;
    }
}

