namespace Zextia.Forms
{
    partial class ManagerProductSupplementForm
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
            this.productSupplementsDG = new System.Windows.Forms.DataGridView();
            this.CreateNewSupplementBtn = new System.Windows.Forms.Button();
            this.DeleteSupplementBtn = new System.Windows.Forms.Button();
            this.UpdateSupplementBtn = new System.Windows.Forms.Button();
            this.ProductNameLbl = new System.Windows.Forms.Label();
            this.ProductDescriptionLbl = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.productSupplementsDG)).BeginInit();
            this.SuspendLayout();
            // 
            // productSupplementsDG
            // 
            this.productSupplementsDG.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.productSupplementsDG.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.productSupplementsDG.Location = new System.Drawing.Point(12, 129);
            this.productSupplementsDG.Name = "productSupplementsDG";
            this.productSupplementsDG.RowHeadersWidth = 51;
            this.productSupplementsDG.RowTemplate.Height = 24;
            this.productSupplementsDG.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.productSupplementsDG.Size = new System.Drawing.Size(1065, 406);
            this.productSupplementsDG.TabIndex = 0;
            // 
            // CreateNewSupplementBtn
            // 
            this.CreateNewSupplementBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.CreateNewSupplementBtn.Location = new System.Drawing.Point(956, 12);
            this.CreateNewSupplementBtn.Name = "CreateNewSupplementBtn";
            this.CreateNewSupplementBtn.Size = new System.Drawing.Size(125, 23);
            this.CreateNewSupplementBtn.TabIndex = 1;
            this.CreateNewSupplementBtn.Text = "Adicionar Lote";
            this.CreateNewSupplementBtn.UseVisualStyleBackColor = true;
            this.CreateNewSupplementBtn.Click += new System.EventHandler(this.CreateNewSupplementBtn_Click);
            // 
            // DeleteSupplementBtn
            // 
            this.DeleteSupplementBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.DeleteSupplementBtn.Location = new System.Drawing.Point(956, 90);
            this.DeleteSupplementBtn.Name = "DeleteSupplementBtn";
            this.DeleteSupplementBtn.Size = new System.Drawing.Size(125, 23);
            this.DeleteSupplementBtn.TabIndex = 2;
            this.DeleteSupplementBtn.Text = "Deletar Lote";
            this.DeleteSupplementBtn.UseVisualStyleBackColor = true;
            this.DeleteSupplementBtn.Click += new System.EventHandler(this.DeleteSupplementBtn_Click);
            // 
            // UpdateSupplementBtn
            // 
            this.UpdateSupplementBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.UpdateSupplementBtn.Location = new System.Drawing.Point(956, 51);
            this.UpdateSupplementBtn.Name = "UpdateSupplementBtn";
            this.UpdateSupplementBtn.Size = new System.Drawing.Size(125, 23);
            this.UpdateSupplementBtn.TabIndex = 3;
            this.UpdateSupplementBtn.Text = "Atualizar Lote";
            this.UpdateSupplementBtn.UseVisualStyleBackColor = true;
            this.UpdateSupplementBtn.Click += new System.EventHandler(this.UpdateSupplementBtn_Click);
            // 
            // ProductNameLbl
            // 
            this.ProductNameLbl.AutoSize = true;
            this.ProductNameLbl.Location = new System.Drawing.Point(13, 12);
            this.ProductNameLbl.Name = "ProductNameLbl";
            this.ProductNameLbl.Size = new System.Drawing.Size(44, 16);
            this.ProductNameLbl.TabIndex = 4;
            this.ProductNameLbl.Text = "label1";
            // 
            // ProductDescriptionLbl
            // 
            this.ProductDescriptionLbl.AutoSize = true;
            this.ProductDescriptionLbl.Location = new System.Drawing.Point(13, 41);
            this.ProductDescriptionLbl.Name = "ProductDescriptionLbl";
            this.ProductDescriptionLbl.Size = new System.Drawing.Size(44, 16);
            this.ProductDescriptionLbl.TabIndex = 5;
            this.ProductDescriptionLbl.Text = "label2";
            // 
            // ManagerProductSupplementForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1089, 549);
            this.Controls.Add(this.ProductDescriptionLbl);
            this.Controls.Add(this.ProductNameLbl);
            this.Controls.Add(this.UpdateSupplementBtn);
            this.Controls.Add(this.DeleteSupplementBtn);
            this.Controls.Add(this.CreateNewSupplementBtn);
            this.Controls.Add(this.productSupplementsDG);
            this.Name = "ManagerProductSupplementForm";
            this.Text = "Gerenciar Produto";
            ((System.ComponentModel.ISupportInitialize)(this.productSupplementsDG)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView productSupplementsDG;
        private System.Windows.Forms.Button CreateNewSupplementBtn;
        private System.Windows.Forms.Button DeleteSupplementBtn;
        private System.Windows.Forms.Button UpdateSupplementBtn;
        private System.Windows.Forms.Label ProductNameLbl;
        private System.Windows.Forms.Label ProductDescriptionLbl;
    }
}