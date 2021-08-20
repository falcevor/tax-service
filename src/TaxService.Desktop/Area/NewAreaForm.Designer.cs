
namespace TaxService.Desktop.Area
{
    partial class NewAreaForm
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
            this.tbName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbInspector = new System.Windows.Forms.TextBox();
            this.btnSelectInspector = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tbName
            // 
            this.tbName.Location = new System.Drawing.Point(12, 37);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(686, 31);
            this.tbName.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(135, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Наименование";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(316, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Закрепленный налоговый инспектор";
            // 
            // tbInspector
            // 
            this.tbInspector.Location = new System.Drawing.Point(12, 99);
            this.tbInspector.Name = "tbInspector";
            this.tbInspector.ReadOnly = true;
            this.tbInspector.Size = new System.Drawing.Size(650, 31);
            this.tbInspector.TabIndex = 0;
            // 
            // btnSelectInspector
            // 
            this.btnSelectInspector.Location = new System.Drawing.Point(660, 99);
            this.btnSelectInspector.Name = "btnSelectInspector";
            this.btnSelectInspector.Size = new System.Drawing.Size(38, 31);
            this.btnSelectInspector.TabIndex = 2;
            this.btnSelectInspector.Text = "...";
            this.btnSelectInspector.UseVisualStyleBackColor = true;
            this.btnSelectInspector.Click += new System.EventHandler(this.btnSelectInspector_Click);
            // 
            // NewAreaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(717, 156);
            this.Controls.Add(this.btnSelectInspector);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbInspector);
            this.Controls.Add(this.tbName);
            this.Name = "NewAreaForm";
            this.Text = "Новая налоговая зона...";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbInspector;
        private System.Windows.Forms.Button btnSelectInspector;
    }
}