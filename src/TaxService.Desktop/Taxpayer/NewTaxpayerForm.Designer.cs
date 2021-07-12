namespace TaxServiceDesktop.Taxpayer
{
    partial class NewTaxpayerForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NewTaxpayerForm));
            this.btnOk = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tbINN = new System.Windows.Forms.TextBox();
            this.tbName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.tbPlaceAddress = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.tbKPP = new System.Windows.Forms.TextBox();
            this.pbAvatar = new System.Windows.Forms.PictureBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tbAdditionalInfo = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.tbChooseAvatar = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.dtpDate = new System.Windows.Forms.DateTimePicker();
            this.panel1 = new System.Windows.Forms.Panel();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tsbtnAddDucument = new System.Windows.Forms.ToolStripButton();
            this.tsbtnDeleteDocument = new System.Windows.Forms.ToolStripButton();
            this.dgvAttachments = new System.Windows.Forms.DataGridView();
            this.cmName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cmDescription = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cmPath = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label10 = new System.Windows.Forms.Label();
            this.tbPercent = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.cbTaxpayerCategory = new System.Windows.Forms.ComboBox();
            this.cbTaxType = new System.Windows.Forms.ComboBox();
            this.cbPlaceType = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.cbTaxArea = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbAvatar)).BeginInit();
            this.panel1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAttachments)).BeginInit();
            this.SuspendLayout();
            // 
            // btnOk
            // 
            this.btnOk.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOk.Location = new System.Drawing.Point(488, 706);
            this.btnOk.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(88, 27);
            this.btnOk.TabIndex = 0;
            this.btnOk.Text = "OK";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancel.Location = new System.Drawing.Point(593, 704);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(88, 27);
            this.btnCancel.TabIndex = 1;
            this.btnCancel.Text = "Отмена";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 58);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "ИНН";
            // 
            // tbINN
            // 
            this.tbINN.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbINN.Location = new System.Drawing.Point(18, 77);
            this.tbINN.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tbINN.Name = "tbINN";
            this.tbINN.Size = new System.Drawing.Size(558, 23);
            this.tbINN.TabIndex = 3;
            // 
            // tbName
            // 
            this.tbName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbName.Location = new System.Drawing.Point(18, 167);
            this.tbName.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(558, 23);
            this.tbName.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 148);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 15);
            this.label2.TabIndex = 4;
            this.label2.Text = "Имя";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 193);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 15);
            this.label3.TabIndex = 6;
            this.label3.Text = "Категория";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(14, 328);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(152, 15);
            this.label4.TabIndex = 10;
            this.label4.Text = "Место постановки на учет";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(14, 373);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(150, 15);
            this.label6.TabIndex = 13;
            this.label6.Text = "Адрес постановки на учет";
            // 
            // tbPlaceAddress
            // 
            this.tbPlaceAddress.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbPlaceAddress.Location = new System.Drawing.Point(18, 392);
            this.tbPlaceAddress.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tbPlaceAddress.Name = "tbPlaceAddress";
            this.tbPlaceAddress.Size = new System.Drawing.Size(662, 23);
            this.tbPlaceAddress.TabIndex = 14;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(14, 103);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(32, 15);
            this.label7.TabIndex = 15;
            this.label7.Text = "КПП";
            // 
            // tbKPP
            // 
            this.tbKPP.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbKPP.Location = new System.Drawing.Point(18, 122);
            this.tbKPP.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tbKPP.Name = "tbKPP";
            this.tbKPP.Size = new System.Drawing.Size(558, 23);
            this.tbKPP.TabIndex = 16;
            // 
            // pbAvatar
            // 
            this.pbAvatar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pbAvatar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pbAvatar.BackgroundImage")));
            this.pbAvatar.Location = new System.Drawing.Point(583, 63);
            this.pbAvatar.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.pbAvatar.Name = "pbAvatar";
            this.pbAvatar.Size = new System.Drawing.Size(97, 100);
            this.pbAvatar.TabIndex = 17;
            this.pbAvatar.TabStop = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(14, 463);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(156, 15);
            this.label5.TabIndex = 18;
            this.label5.Text = "Дополнительные сведения";
            // 
            // tbAdditionalInfo
            // 
            this.tbAdditionalInfo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbAdditionalInfo.Location = new System.Drawing.Point(18, 482);
            this.tbAdditionalInfo.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tbAdditionalInfo.Multiline = true;
            this.tbAdditionalInfo.Name = "tbAdditionalInfo";
            this.tbAdditionalInfo.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbAdditionalInfo.Size = new System.Drawing.Size(662, 66);
            this.tbAdditionalInfo.TabIndex = 19;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(14, 553);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(70, 15);
            this.label8.TabIndex = 21;
            this.label8.Text = "Документы";
            // 
            // tbChooseAvatar
            // 
            this.tbChooseAvatar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tbChooseAvatar.Location = new System.Drawing.Point(583, 163);
            this.tbChooseAvatar.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tbChooseAvatar.Name = "tbChooseAvatar";
            this.tbChooseAvatar.Size = new System.Drawing.Size(97, 27);
            this.tbChooseAvatar.TabIndex = 22;
            this.tbChooseAvatar.Text = "Обзор...";
            this.tbChooseAvatar.UseVisualStyleBackColor = true;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(14, 418);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(142, 15);
            this.label9.TabIndex = 23;
            this.label9.Text = "Дата постановки на учет";
            // 
            // dtpDate
            // 
            this.dtpDate.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtpDate.Location = new System.Drawing.Point(18, 437);
            this.dtpDate.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.dtpDate.Name = "dtpDate";
            this.dtpDate.Size = new System.Drawing.Size(658, 23);
            this.dtpDate.TabIndex = 24;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.toolStrip1);
            this.panel1.Controls.Add(this.dgvAttachments);
            this.panel1.Location = new System.Drawing.Point(20, 572);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(660, 126);
            this.panel1.TabIndex = 48;
            // 
            // toolStrip1
            // 
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbtnAddDucument,
            this.tsbtnDeleteDocument});
            this.toolStrip1.Location = new System.Drawing.Point(0, 101);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(660, 25);
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
            // dgvAttachments
            // 
            this.dgvAttachments.AllowUserToAddRows = false;
            this.dgvAttachments.AllowUserToDeleteRows = false;
            this.dgvAttachments.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAttachments.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cmName,
            this.cmDescription,
            this.cmPath});
            this.dgvAttachments.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvAttachments.Location = new System.Drawing.Point(0, 0);
            this.dgvAttachments.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.dgvAttachments.Name = "dgvAttachments";
            this.dgvAttachments.Size = new System.Drawing.Size(660, 126);
            this.dgvAttachments.TabIndex = 42;
            // 
            // cmName
            // 
            this.cmName.HeaderText = "Наименование";
            this.cmName.Name = "cmName";
            this.cmName.ReadOnly = true;
            // 
            // cmDescription
            // 
            this.cmDescription.HeaderText = "Описание";
            this.cmDescription.Name = "cmDescription";
            this.cmDescription.ReadOnly = true;
            // 
            // cmPath
            // 
            this.cmPath.HeaderText = "Путь";
            this.cmPath.Name = "cmPath";
            this.cmPath.ReadOnly = true;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(14, 238);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(132, 15);
            this.label10.TabIndex = 49;
            this.label10.Text = "Тип налогообложения";
            // 
            // tbPercent
            // 
            this.tbPercent.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbPercent.Location = new System.Drawing.Point(18, 302);
            this.tbPercent.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tbPercent.Name = "tbPercent";
            this.tbPercent.Size = new System.Drawing.Size(662, 23);
            this.tbPercent.TabIndex = 51;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(16, 283);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(112, 15);
            this.label11.TabIndex = 52;
            this.label11.Text = "Процентная ставка";
            // 
            // cbTaxpayerCategory
            // 
            this.cbTaxpayerCategory.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbTaxpayerCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTaxpayerCategory.FormattingEnabled = true;
            this.cbTaxpayerCategory.Items.AddRange(new object[] {
            "Организации",
            "Физическое лицо или индивидуальный предприниматель"});
            this.cbTaxpayerCategory.Location = new System.Drawing.Point(18, 212);
            this.cbTaxpayerCategory.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.cbTaxpayerCategory.Name = "cbTaxpayerCategory";
            this.cbTaxpayerCategory.Size = new System.Drawing.Size(662, 23);
            this.cbTaxpayerCategory.TabIndex = 53;
            // 
            // cbTaxType
            // 
            this.cbTaxType.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbTaxType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTaxType.FormattingEnabled = true;
            this.cbTaxType.Items.AddRange(new object[] {
            "Общая система налогообложения",
            "Упрощенная система налогообложения",
            "Патентная система налогообложения",
            "Вмененная система налогообложения или единый налог на вмененный доход",
            "Единый сельскохозяйственный налог"});
            this.cbTaxType.Location = new System.Drawing.Point(18, 257);
            this.cbTaxType.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.cbTaxType.Name = "cbTaxType";
            this.cbTaxType.Size = new System.Drawing.Size(662, 23);
            this.cbTaxType.TabIndex = 54;
            // 
            // cbPlaceType
            // 
            this.cbPlaceType.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbPlaceType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbPlaceType.FormattingEnabled = true;
            this.cbPlaceType.Items.AddRange(new object[] {
            "По местонахождению организации",
            "По местонахождению обособленных подразделений организации",
            "По местонахождению имущества",
            "По месту жительства",
            "По местонахождению имущества",
            "По местонахождению транспортных средств"});
            this.cbPlaceType.Location = new System.Drawing.Point(18, 346);
            this.cbPlaceType.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.cbPlaceType.Name = "cbPlaceType";
            this.cbPlaceType.Size = new System.Drawing.Size(662, 23);
            this.cbPlaceType.TabIndex = 55;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(18, 9);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(94, 15);
            this.label12.TabIndex = 2;
            this.label12.Text = "Налоговая зона";
            // 
            // cbTaxArea
            // 
            this.cbTaxArea.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbTaxArea.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTaxArea.FormattingEnabled = true;
            this.cbTaxArea.Items.AddRange(new object[] {
            "Общая система налогообложения",
            "Упрощенная система налогообложения",
            "Патентная система налогообложения",
            "Вмененная система налогообложения или единый налог на вмененный доход",
            "Единый сельскохозяйственный налог"});
            this.cbTaxArea.Location = new System.Drawing.Point(18, 27);
            this.cbTaxArea.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.cbTaxArea.Name = "cbTaxArea";
            this.cbTaxArea.Size = new System.Drawing.Size(662, 23);
            this.cbTaxArea.TabIndex = 56;
            // 
            // NewTaxpayerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(696, 745);
            this.Controls.Add(this.cbTaxArea);
            this.Controls.Add(this.cbPlaceType);
            this.Controls.Add(this.cbTaxType);
            this.Controls.Add(this.cbTaxpayerCategory);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.tbPercent);
            this.Controls.Add(this.label10);
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
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbINN);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOk);
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "NewTaxpayerForm";
            this.Text = "Новый налогоплательщик";
            ((System.ComponentModel.ISupportInitialize)(this.pbAvatar)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAttachments)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbINN;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbPlaceAddress;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tbKPP;
        private System.Windows.Forms.PictureBox pbAvatar;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbAdditionalInfo;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button tbChooseAvatar;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DateTimePicker dtpDate;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tsbtnAddDucument;
        private System.Windows.Forms.ToolStripButton tsbtnDeleteDocument;
        private System.Windows.Forms.DataGridView dgvAttachments;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox tbPercent;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox cbTaxpayerCategory;
        private System.Windows.Forms.ComboBox cbTaxType;
        private System.Windows.Forms.ComboBox cbPlaceType;
        private System.Windows.Forms.DataGridViewTextBoxColumn cmName;
        private System.Windows.Forms.DataGridViewTextBoxColumn cmDescription;
        private System.Windows.Forms.DataGridViewTextBoxColumn cmPath;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ComboBox cbTaxArea;
    }
}