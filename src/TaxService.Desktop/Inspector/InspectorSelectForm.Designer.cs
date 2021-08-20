
namespace TaxService.Desktop.Inspect
{
    partial class InspectorSelectForm
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
            this.components = new System.ComponentModel.Container();
            this.dgvInspector = new System.Windows.Forms.DataGridView();
            this.InspectorDataBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgvInspector)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.InspectorDataBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvInspector
            // 
            this.dgvInspector.AllowUserToAddRows = false;
            this.dgvInspector.AllowUserToDeleteRows = false;
            this.dgvInspector.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvInspector.Location = new System.Drawing.Point(12, 12);
            this.dgvInspector.Name = "dgvInspector";
            this.dgvInspector.ReadOnly = true;
            this.dgvInspector.RowHeadersWidth = 62;
            this.dgvInspector.RowTemplate.Height = 33;
            this.dgvInspector.Size = new System.Drawing.Size(360, 225);
            this.dgvInspector.TabIndex = 0;
            // 
            // InspectorSelectForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dgvInspector);
            this.Name = "InspectorSelectForm";
            this.Text = "InspectorSelectForm";
            ((System.ComponentModel.ISupportInitialize)(this.dgvInspector)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.InspectorDataBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvInspector;
        private System.Windows.Forms.BindingSource InspectorDataBindingSource;
    }
}