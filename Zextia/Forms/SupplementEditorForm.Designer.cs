namespace Zextia.Forms
{
    partial class SupplementEditorForm
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
            this.ProductNameLbl = new System.Windows.Forms.Label();
            this.ProductDescriptionLbl = new System.Windows.Forms.Label();
            this.SupplementBatchTxt = new System.Windows.Forms.TextBox();
            this.CancelBtn = new System.Windows.Forms.Button();
            this.SaveBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ProductNameLbl
            // 
            this.ProductNameLbl.AutoSize = true;
            this.ProductNameLbl.Location = new System.Drawing.Point(12, 18);
            this.ProductNameLbl.Name = "ProductNameLbl";
            this.ProductNameLbl.Size = new System.Drawing.Size(44, 16);
            this.ProductNameLbl.TabIndex = 0;
            this.ProductNameLbl.Text = "label1";
            // 
            // ProductDescriptionLbl
            // 
            this.ProductDescriptionLbl.AutoSize = true;
            this.ProductDescriptionLbl.Location = new System.Drawing.Point(12, 50);
            this.ProductDescriptionLbl.Name = "ProductDescriptionLbl";
            this.ProductDescriptionLbl.Size = new System.Drawing.Size(44, 16);
            this.ProductDescriptionLbl.TabIndex = 1;
            this.ProductDescriptionLbl.Text = "label2";
            // 
            // SupplementBatchTxt
            // 
            this.SupplementBatchTxt.Location = new System.Drawing.Point(15, 85);
            this.SupplementBatchTxt.Name = "SupplementBatchTxt";
            this.SupplementBatchTxt.Size = new System.Drawing.Size(442, 22);
            this.SupplementBatchTxt.TabIndex = 2;
            // 
            // CancelBtn
            // 
            this.CancelBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.CancelBtn.Location = new System.Drawing.Point(12, 127);
            this.CancelBtn.Name = "CancelBtn";
            this.CancelBtn.Size = new System.Drawing.Size(75, 23);
            this.CancelBtn.TabIndex = 3;
            this.CancelBtn.Text = "Cancelar";
            this.CancelBtn.UseVisualStyleBackColor = true;
            this.CancelBtn.Click += new System.EventHandler(this.CancelBtn_Click);
            // 
            // SaveBtn
            // 
            this.SaveBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.SaveBtn.Location = new System.Drawing.Point(379, 127);
            this.SaveBtn.Name = "SaveBtn";
            this.SaveBtn.Size = new System.Drawing.Size(75, 23);
            this.SaveBtn.TabIndex = 4;
            this.SaveBtn.Text = "Salvar";
            this.SaveBtn.UseVisualStyleBackColor = true;
            this.SaveBtn.Click += new System.EventHandler(this.SaveBtn_Click);
            // 
            // SupplementEditorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(466, 162);
            this.Controls.Add(this.SaveBtn);
            this.Controls.Add(this.CancelBtn);
            this.Controls.Add(this.SupplementBatchTxt);
            this.Controls.Add(this.ProductDescriptionLbl);
            this.Controls.Add(this.ProductNameLbl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SupplementEditorForm";
            this.Text = "SupplementEditorForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label ProductNameLbl;
        private System.Windows.Forms.Label ProductDescriptionLbl;
        private System.Windows.Forms.TextBox SupplementBatchTxt;
        private System.Windows.Forms.Button CancelBtn;
        private System.Windows.Forms.Button SaveBtn;
    }
}