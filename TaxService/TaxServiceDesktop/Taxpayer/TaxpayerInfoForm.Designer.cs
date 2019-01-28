namespace TaxServiceDesktop.Taxpayer
{
    partial class TaxpayerInfoForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TaxpayerInfoForm));
            this.dtpDate = new System.Windows.Forms.DateTimePicker();
            this.label9 = new System.Windows.Forms.Label();
            this.tbChooseAvatar = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.dgvAttachments = new System.Windows.Forms.DataGridView();
            this.cmId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cmName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cmDescription = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tbAdditionalInfo = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.pbAvatar = new System.Windows.Forms.PictureBox();
            this.tbKPP = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.tbPlaceAddress = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tbPlaceCategory = new System.Windows.Forms.TextBox();
            this.tbCategory = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbINN = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnOk = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tsbtnAddDucument = new System.Windows.Forms.ToolStripButton();
            this.tsbtnDeleteDocument = new System.Windows.Forms.ToolStripButton();
            this.btnDetalization = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.tbPercent = new System.Windows.Forms.TextBox();
            this.tbTaxType = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAttachments)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbAvatar)).BeginInit();
            this.panel1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dtpDate
            // 
            this.dtpDate.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtpDate.Enabled = false;
            this.dtpDate.Location = new System.Drawing.Point(12, 337);
            this.dtpDate.Name = "dtpDate";
            this.dtpDate.Size = new System.Drawing.Size(576, 20);
            this.dtpDate.TabIndex = 46;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(9, 321);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(134, 13);
            this.label9.TabIndex = 45;
            this.label9.Text = "Дата постановки на учет";
            // 
            // tbChooseAvatar
            // 
            this.tbChooseAvatar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tbChooseAvatar.Location = new System.Drawing.Point(505, 103);
            this.tbChooseAvatar.Name = "tbChooseAvatar";
            this.tbChooseAvatar.Size = new System.Drawing.Size(83, 23);
            this.tbChooseAvatar.TabIndex = 44;
            this.tbChooseAvatar.Text = "Обзор...";
            this.tbChooseAvatar.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(9, 431);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(66, 13);
            this.label8.TabIndex = 43;
            this.label8.Text = "Документы";
            // 
            // dgvAttachments
            // 
            this.dgvAttachments.AllowUserToAddRows = false;
            this.dgvAttachments.AllowUserToDeleteRows = false;
            this.dgvAttachments.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvAttachments.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAttachments.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cmId,
            this.cmName,
            this.cmDescription});
            this.dgvAttachments.Location = new System.Drawing.Point(0, 28);
            this.dgvAttachments.Name = "dgvAttachments";
            this.dgvAttachments.Size = new System.Drawing.Size(576, 64);
            this.dgvAttachments.TabIndex = 42;
            this.dgvAttachments.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.dgvAttachments_MouseDoubleClick);
            // 
            // cmId
            // 
            this.cmId.HeaderText = "ID";
            this.cmId.Name = "cmId";
            this.cmId.ReadOnly = true;
            // 
            // cmName
            // 
            this.cmName.HeaderText = "Название";
            this.cmName.Name = "cmName";
            this.cmName.ReadOnly = true;
            // 
            // cmDescription
            // 
            this.cmDescription.HeaderText = "Описание";
            this.cmDescription.Name = "cmDescription";
            this.cmDescription.ReadOnly = true;
            // 
            // tbAdditionalInfo
            // 
            this.tbAdditionalInfo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbAdditionalInfo.Location = new System.Drawing.Point(12, 376);
            this.tbAdditionalInfo.Multiline = true;
            this.tbAdditionalInfo.Name = "tbAdditionalInfo";
            this.tbAdditionalInfo.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbAdditionalInfo.Size = new System.Drawing.Size(576, 49);
            this.tbAdditionalInfo.TabIndex = 41;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(9, 360);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(146, 13);
            this.label5.TabIndex = 40;
            this.label5.Text = "Дополнительные сведения";
            // 
            // pbAvatar
            // 
            this.pbAvatar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pbAvatar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pbAvatar.BackgroundImage")));
            this.pbAvatar.Location = new System.Drawing.Point(505, 13);
            this.pbAvatar.Name = "pbAvatar";
            this.pbAvatar.Size = new System.Drawing.Size(83, 87);
            this.pbAvatar.TabIndex = 39;
            this.pbAvatar.TabStop = false;
            // 
            // tbKPP
            // 
            this.tbKPP.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbKPP.Location = new System.Drawing.Point(12, 64);
            this.tbKPP.Name = "tbKPP";
            this.tbKPP.ReadOnly = true;
            this.tbKPP.Size = new System.Drawing.Size(487, 20);
            this.tbKPP.TabIndex = 38;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(9, 48);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(30, 13);
            this.label7.TabIndex = 37;
            this.label7.Text = "КПП";
            // 
            // tbPlaceAddress
            // 
            this.tbPlaceAddress.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbPlaceAddress.Location = new System.Drawing.Point(12, 298);
            this.tbPlaceAddress.Name = "tbPlaceAddress";
            this.tbPlaceAddress.Size = new System.Drawing.Size(576, 20);
            this.tbPlaceAddress.TabIndex = 36;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(9, 282);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(139, 13);
            this.label6.TabIndex = 35;
            this.label6.Text = "Адрес постановки на учет";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 243);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(140, 13);
            this.label4.TabIndex = 34;
            this.label4.Text = "Место постановки на учет";
            // 
            // tbPlaceCategory
            // 
            this.tbPlaceCategory.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbPlaceCategory.Location = new System.Drawing.Point(12, 259);
            this.tbPlaceCategory.Name = "tbPlaceCategory";
            this.tbPlaceCategory.ReadOnly = true;
            this.tbPlaceCategory.Size = new System.Drawing.Size(576, 20);
            this.tbPlaceCategory.TabIndex = 33;
            // 
            // tbCategory
            // 
            this.tbCategory.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbCategory.Location = new System.Drawing.Point(12, 142);
            this.tbCategory.Name = "tbCategory";
            this.tbCategory.ReadOnly = true;
            this.tbCategory.Size = new System.Drawing.Size(576, 20);
            this.tbCategory.TabIndex = 32;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 126);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 13);
            this.label3.TabIndex = 31;
            this.label3.Text = "Категория";
            // 
            // tbName
            // 
            this.tbName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbName.Location = new System.Drawing.Point(12, 103);
            this.tbName.Name = "tbName";
            this.tbName.ReadOnly = true;
            this.tbName.Size = new System.Drawing.Size(487, 20);
            this.tbName.TabIndex = 30;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 13);
            this.label2.TabIndex = 29;
            this.label2.Text = "Имя";
            // 
            // tbINN
            // 
            this.tbINN.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbINN.Location = new System.Drawing.Point(12, 25);
            this.tbINN.Name = "tbINN";
            this.tbINN.ReadOnly = true;
            this.tbINN.Size = new System.Drawing.Size(487, 20);
            this.tbINN.TabIndex = 28;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 13);
            this.label1.TabIndex = 27;
            this.label1.Text = "ИНН";
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancel.Location = new System.Drawing.Point(478, 545);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(110, 23);
            this.btnCancel.TabIndex = 26;
            this.btnCancel.Text = "Отмена";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnOk
            // 
            this.btnOk.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOk.Location = new System.Drawing.Point(365, 545);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(107, 23);
            this.btnOk.TabIndex = 25;
            this.btnOk.Text = "OK";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.toolStrip1);
            this.panel1.Controls.Add(this.dgvAttachments);
            this.panel1.Location = new System.Drawing.Point(12, 447);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(576, 92);
            this.panel1.TabIndex = 47;
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbtnAddDucument,
            this.tsbtnDeleteDocument});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(576, 25);
            this.toolStrip1.TabIndex = 43;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // tsbtnAddDucument
            // 
            this.tsbtnAddDucument.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbtnAddDucument.Image = ((System.Drawing.Image)(resources.GetObject("tsbtnAddDucument.Image")));
            this.tsbtnAddDucument.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtnAddDucument.Name = "tsbtnAddDucument";
            this.tsbtnAddDucument.Size = new System.Drawing.Size(23, 22);
            this.tsbtnAddDucument.Text = "toolStripButton1";
            this.tsbtnAddDucument.Click += new System.EventHandler(this.tsbtnAddDucument_Click);
            // 
            // tsbtnDeleteDocument
            // 
            this.tsbtnDeleteDocument.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbtnDeleteDocument.Image = ((System.Drawing.Image)(resources.GetObject("tsbtnDeleteDocument.Image")));
            this.tsbtnDeleteDocument.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtnDeleteDocument.Name = "tsbtnDeleteDocument";
            this.tsbtnDeleteDocument.Size = new System.Drawing.Size(23, 22);
            this.tsbtnDeleteDocument.Text = "toolStripButton2";
            this.tsbtnDeleteDocument.Click += new System.EventHandler(this.tsbtnDeleteDocument_Click);
            // 
            // btnDetalization
            // 
            this.btnDetalization.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnDetalization.Location = new System.Drawing.Point(12, 545);
            this.btnDetalization.Name = "btnDetalization";
            this.btnDetalization.Size = new System.Drawing.Size(143, 23);
            this.btnDetalization.TabIndex = 48;
            this.btnDetalization.Text = "Детализация выплат";
            this.btnDetalization.UseVisualStyleBackColor = true;
            this.btnDetalization.Click += new System.EventHandler(this.btnDetalization_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(9, 204);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(106, 13);
            this.label11.TabIndex = 56;
            this.label11.Text = "Процентная ставка";
            // 
            // tbPercent
            // 
            this.tbPercent.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbPercent.Location = new System.Drawing.Point(12, 220);
            this.tbPercent.Name = "tbPercent";
            this.tbPercent.Size = new System.Drawing.Size(576, 20);
            this.tbPercent.TabIndex = 55;
            // 
            // tbTaxType
            // 
            this.tbTaxType.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbTaxType.Location = new System.Drawing.Point(12, 181);
            this.tbTaxType.Name = "tbTaxType";
            this.tbTaxType.ReadOnly = true;
            this.tbTaxType.Size = new System.Drawing.Size(576, 20);
            this.tbTaxType.TabIndex = 54;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(9, 165);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(120, 13);
            this.label10.TabIndex = 53;
            this.label10.Text = "Тип налогообложения";
            // 
            // TaxpayerInfoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 580);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.tbPercent);
            this.Controls.Add(this.tbTaxType);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.btnDetalization);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dtpDate);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.tbChooseAvatar);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.tbAdditionalInfo);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.pbAvatar);
            this.Controls.Add(this.tbKPP);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.tbPlaceAddress);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tbPlaceCategory);
            this.Controls.Add(this.tbCategory);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbINN);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOk);
            this.Name = "TaxpayerInfoForm";
            this.Text = "Информация о налогоплательщике";
            ((System.ComponentModel.ISupportInitialize)(this.dgvAttachments)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbAvatar)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dtpDate;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button tbChooseAvatar;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DataGridView dgvAttachments;
        private System.Windows.Forms.TextBox tbAdditionalInfo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox pbAvatar;
        private System.Windows.Forms.TextBox tbKPP;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tbPlaceAddress;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbPlaceCategory;
        private System.Windows.Forms.TextBox tbCategory;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbINN;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tsbtnAddDucument;
        private System.Windows.Forms.ToolStripButton tsbtnDeleteDocument;
        private System.Windows.Forms.Button btnDetalization;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox tbPercent;
        private System.Windows.Forms.TextBox tbTaxType;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DataGridViewTextBoxColumn cmId;
        private System.Windows.Forms.DataGridViewTextBoxColumn cmName;
        private System.Windows.Forms.DataGridViewTextBoxColumn cmDescription;
    }
}