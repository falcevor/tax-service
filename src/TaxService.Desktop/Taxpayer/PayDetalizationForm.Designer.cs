namespace TaxServiceDesktop.Taxpayer
{
    partial class PayDetalizationForm
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
            this.pnMain = new System.Windows.Forms.Panel();
            this.pnRight = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.tbTotalPay = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.spMain = new System.Windows.Forms.Splitter();
            this.pnLeft = new System.Windows.Forms.Panel();
            this.dgvIncome = new System.Windows.Forms.DataGridView();
            this.tbTotalIncome = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dtpFrom = new System.Windows.Forms.DateTimePicker();
            this.dtpTo = new System.Windows.Forms.DateTimePicker();
            this.btnApplyPeriod = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.tbPercent = new System.Windows.Forms.TextBox();
            this.tbTotalIncome2 = new System.Windows.Forms.TextBox();
            this.tbTotalPay2 = new System.Windows.Forms.TextBox();
            this.tbDebt = new System.Windows.Forms.TextBox();
            this.pnMain.SuspendLayout();
            this.pnRight.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.pnLeft.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvIncome)).BeginInit();
            this.SuspendLayout();
            // 
            // pnMain
            // 
            this.pnMain.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnMain.Controls.Add(this.pnRight);
            this.pnMain.Controls.Add(this.spMain);
            this.pnMain.Controls.Add(this.pnLeft);
            this.pnMain.Location = new System.Drawing.Point(12, 207);
            this.pnMain.Name = "pnMain";
            this.pnMain.Size = new System.Drawing.Size(1018, 222);
            this.pnMain.TabIndex = 0;
            // 
            // pnRight
            // 
            this.pnRight.Controls.Add(this.dataGridView1);
            this.pnRight.Controls.Add(this.tbTotalPay);
            this.pnRight.Controls.Add(this.label5);
            this.pnRight.Controls.Add(this.label2);
            this.pnRight.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnRight.Location = new System.Drawing.Point(532, 0);
            this.pnRight.Name = "pnRight";
            this.pnRight.Size = new System.Drawing.Size(486, 222);
            this.pnRight.TabIndex = 2;
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(6, 16);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(477, 180);
            this.dataGridView1.TabIndex = 4;
            // 
            // tbTotalPay
            // 
            this.tbTotalPay.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.tbTotalPay.Location = new System.Drawing.Point(271, 202);
            this.tbTotalPay.Name = "tbTotalPay";
            this.tbTotalPay.ReadOnly = true;
            this.tbTotalPay.Size = new System.Drawing.Size(215, 20);
            this.tbTotalPay.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(226, 205);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(39, 13);
            this.label5.TabIndex = 2;
            this.label5.Text = "ИТОГ:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Выплаты";
            // 
            // spMain
            // 
            this.spMain.Location = new System.Drawing.Point(529, 0);
            this.spMain.Name = "spMain";
            this.spMain.Size = new System.Drawing.Size(3, 222);
            this.spMain.TabIndex = 1;
            this.spMain.TabStop = false;
            // 
            // pnLeft
            // 
            this.pnLeft.Controls.Add(this.dgvIncome);
            this.pnLeft.Controls.Add(this.tbTotalIncome);
            this.pnLeft.Controls.Add(this.label4);
            this.pnLeft.Controls.Add(this.label1);
            this.pnLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnLeft.Location = new System.Drawing.Point(0, 0);
            this.pnLeft.Name = "pnLeft";
            this.pnLeft.Size = new System.Drawing.Size(529, 222);
            this.pnLeft.TabIndex = 0;
            // 
            // dgvIncome
            // 
            this.dgvIncome.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvIncome.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvIncome.Location = new System.Drawing.Point(0, 16);
            this.dgvIncome.Name = "dgvIncome";
            this.dgvIncome.Size = new System.Drawing.Size(523, 180);
            this.dgvIncome.TabIndex = 3;
            // 
            // tbTotalIncome
            // 
            this.tbTotalIncome.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.tbTotalIncome.Location = new System.Drawing.Point(314, 202);
            this.tbTotalIncome.Name = "tbTotalIncome";
            this.tbTotalIncome.ReadOnly = true;
            this.tbTotalIncome.Size = new System.Drawing.Size(215, 20);
            this.tbTotalIncome.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(269, 205);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "ИТОГ:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Доходы";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Период";
            // 
            // dtpFrom
            // 
            this.dtpFrom.Location = new System.Drawing.Point(12, 25);
            this.dtpFrom.Name = "dtpFrom";
            this.dtpFrom.Size = new System.Drawing.Size(137, 20);
            this.dtpFrom.TabIndex = 2;
            // 
            // dtpTo
            // 
            this.dtpTo.Location = new System.Drawing.Point(155, 25);
            this.dtpTo.Name = "dtpTo";
            this.dtpTo.Size = new System.Drawing.Size(137, 20);
            this.dtpTo.TabIndex = 3;
            // 
            // btnApplyPeriod
            // 
            this.btnApplyPeriod.Location = new System.Drawing.Point(298, 22);
            this.btnApplyPeriod.Name = "btnApplyPeriod";
            this.btnApplyPeriod.Size = new System.Drawing.Size(89, 23);
            this.btnApplyPeriod.TabIndex = 4;
            this.btnApplyPeriod.Text = "Применить";
            this.btnApplyPeriod.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(9, 48);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(106, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Процентная ставка";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(9, 87);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(93, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "Доход за период";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(9, 126);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(166, 13);
            this.label8.TabIndex = 7;
            this.label8.Text = "Налоговые выплаты за период";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(9, 165);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(141, 13);
            this.label9.TabIndex = 8;
            this.label9.Text = "Задолженность за период";
            // 
            // tbPercent
            // 
            this.tbPercent.Location = new System.Drawing.Point(12, 64);
            this.tbPercent.Name = "tbPercent";
            this.tbPercent.ReadOnly = true;
            this.tbPercent.Size = new System.Drawing.Size(374, 20);
            this.tbPercent.TabIndex = 9;
            // 
            // tbTotalIncome2
            // 
            this.tbTotalIncome2.Location = new System.Drawing.Point(12, 103);
            this.tbTotalIncome2.Name = "tbTotalIncome2";
            this.tbTotalIncome2.ReadOnly = true;
            this.tbTotalIncome2.Size = new System.Drawing.Size(374, 20);
            this.tbTotalIncome2.TabIndex = 10;
            // 
            // tbTotalPay2
            // 
            this.tbTotalPay2.Location = new System.Drawing.Point(12, 142);
            this.tbTotalPay2.Name = "tbTotalPay2";
            this.tbTotalPay2.ReadOnly = true;
            this.tbTotalPay2.Size = new System.Drawing.Size(374, 20);
            this.tbTotalPay2.TabIndex = 11;
            // 
            // tbDebt
            // 
            this.tbDebt.Location = new System.Drawing.Point(12, 181);
            this.tbDebt.Name = "tbDebt";
            this.tbDebt.ReadOnly = true;
            this.tbDebt.Size = new System.Drawing.Size(374, 20);
            this.tbDebt.TabIndex = 12;
            // 
            // PayDetalizationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1042, 441);
            this.Controls.Add(this.tbDebt);
            this.Controls.Add(this.tbTotalPay2);
            this.Controls.Add(this.tbTotalIncome2);
            this.Controls.Add(this.tbPercent);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnApplyPeriod);
            this.Controls.Add(this.dtpTo);
            this.Controls.Add(this.dtpFrom);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.pnMain);
            this.Name = "PayDetalizationForm";
            this.Text = "Детализация выплат";
            this.pnMain.ResumeLayout(false);
            this.pnRight.ResumeLayout(false);
            this.pnRight.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.pnLeft.ResumeLayout(false);
            this.pnLeft.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvIncome)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnMain;
        private System.Windows.Forms.Panel pnRight;
        private System.Windows.Forms.Splitter spMain;
        private System.Windows.Forms.Panel pnLeft;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dtpFrom;
        private System.Windows.Forms.DateTimePicker dtpTo;
        private System.Windows.Forms.Button btnApplyPeriod;
        private System.Windows.Forms.TextBox tbTotalPay;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbTotalIncome;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridView dgvIncome;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox tbPercent;
        private System.Windows.Forms.TextBox tbTotalIncome2;
        private System.Windows.Forms.TextBox tbTotalPay2;
        private System.Windows.Forms.TextBox tbDebt;
    }
}