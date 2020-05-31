namespace BitcoinWallet_beta1._0_
{
    partial class TransactionInformation
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
            this.dataGridViewTrInfo = new System.Windows.Forms.DataGridView();
            this.bitcoinsAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.paymentScript = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bitcoinAdress = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.textBoxFee = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.labelTransactionType = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTrInfo)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewTrInfo
            // 
            this.dataGridViewTrInfo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewTrInfo.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.bitcoinsAmount,
            this.paymentScript,
            this.bitcoinAdress});
            this.dataGridViewTrInfo.Location = new System.Drawing.Point(12, 36);
            this.dataGridViewTrInfo.Name = "dataGridViewTrInfo";
            this.dataGridViewTrInfo.Size = new System.Drawing.Size(381, 191);
            this.dataGridViewTrInfo.TabIndex = 0;
            // 
            // bitcoinsAmount
            // 
            this.bitcoinsAmount.HeaderText = "Bitcoins Amount";
            this.bitcoinsAmount.Name = "bitcoinsAmount";
            this.bitcoinsAmount.ReadOnly = true;
            this.bitcoinsAmount.Width = 140;
            // 
            // paymentScript
            // 
            this.paymentScript.HeaderText = "Payment Script";
            this.paymentScript.Name = "paymentScript";
            this.paymentScript.ReadOnly = true;
            // 
            // bitcoinAdress
            // 
            this.bitcoinAdress.HeaderText = "Adress";
            this.bitcoinAdress.Name = "bitcoinAdress";
            this.bitcoinAdress.ReadOnly = true;
            // 
            // textBoxFee
            // 
            this.textBoxFee.Location = new System.Drawing.Point(13, 258);
            this.textBoxFee.Name = "textBoxFee";
            this.textBoxFee.ReadOnly = true;
            this.textBoxFee.Size = new System.Drawing.Size(380, 20);
            this.textBoxFee.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 239);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Transaction\'s fee";
            // 
            // labelTransactionType
            // 
            this.labelTransactionType.AutoSize = true;
            this.labelTransactionType.Location = new System.Drawing.Point(12, 13);
            this.labelTransactionType.Name = "labelTransactionType";
            this.labelTransactionType.Size = new System.Drawing.Size(89, 13);
            this.labelTransactionType.TabIndex = 3;
            this.labelTransactionType.Text = "Transaction type:";
            // 
            // TransactionInformation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(408, 295);
            this.Controls.Add(this.labelTransactionType);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxFee);
            this.Controls.Add(this.dataGridViewTrInfo);
            this.Name = "TransactionInformation";
            this.Text = "TransactionInformation";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTrInfo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewTrInfo;
        private System.Windows.Forms.DataGridViewTextBoxColumn bitcoinsAmount;
        private System.Windows.Forms.DataGridViewTextBoxColumn paymentScript;
        private System.Windows.Forms.DataGridViewTextBoxColumn bitcoinAdress;
        private System.Windows.Forms.TextBox textBoxFee;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelTransactionType;
    }
}