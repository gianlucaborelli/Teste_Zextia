namespace Zextia
{
    partial class MainForm
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.productsGV = new System.Windows.Forms.DataGridView();
            this.registerNewProductBtn = new System.Windows.Forms.Button();
            this.UpdateProductBtn = new System.Windows.Forms.Button();
            this.DeleteProductBtn = new System.Windows.Forms.Button();
            this.ManagerProductBtn = new System.Windows.Forms.Button();
            this.SearchProductTxt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.productsGV)).BeginInit();
            this.SuspendLayout();
            // 
            // productsGV
            // 
            this.productsGV.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.productsGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.productsGV.Location = new System.Drawing.Point(12, 170);
            this.productsGV.Name = "productsGV";
            this.productsGV.ReadOnly = true;
            this.productsGV.RowHeadersWidth = 51;
            this.productsGV.RowTemplate.Height = 24;
            this.productsGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.productsGV.Size = new System.Drawing.Size(724, 490);
            this.productsGV.TabIndex = 0;
            this.productsGV.SelectionChanged += new System.EventHandler(this.productsGV_SelectionChanged);
            // 
            // registerNewProductBtn
            // 
            this.registerNewProductBtn.Location = new System.Drawing.Point(9, 7);
            this.registerNewProductBtn.Name = "registerNewProductBtn";
            this.registerNewProductBtn.Size = new System.Drawing.Size(192, 30);
            this.registerNewProductBtn.TabIndex = 1;
            this.registerNewProductBtn.Text = "Cadastrar novo produto";
            this.registerNewProductBtn.UseVisualStyleBackColor = true;
            this.registerNewProductBtn.Click += new System.EventHandler(this.registerNewProductBtn_Click);
            // 
            // UpdateProductBtn
            // 
            this.UpdateProductBtn.Location = new System.Drawing.Point(9, 43);
            this.UpdateProductBtn.Name = "UpdateProductBtn";
            this.UpdateProductBtn.Size = new System.Drawing.Size(192, 30);
            this.UpdateProductBtn.TabIndex = 2;
            this.UpdateProductBtn.Text = "Atualizar produto";
            this.UpdateProductBtn.UseVisualStyleBackColor = true;
            this.UpdateProductBtn.Click += new System.EventHandler(this.UpdateProductBtn_Click);
            // 
            // DeleteProductBtn
            // 
            this.DeleteProductBtn.Location = new System.Drawing.Point(9, 79);
            this.DeleteProductBtn.Name = "DeleteProductBtn";
            this.DeleteProductBtn.Size = new System.Drawing.Size(192, 30);
            this.DeleteProductBtn.TabIndex = 3;
            this.DeleteProductBtn.Text = "Deletar produto";
            this.DeleteProductBtn.UseVisualStyleBackColor = true;
            this.DeleteProductBtn.Click += new System.EventHandler(this.DeleteProductBtn_Click);
            // 
            // ManagerProductBtn
            // 
            this.ManagerProductBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ManagerProductBtn.Location = new System.Drawing.Point(544, 133);
            this.ManagerProductBtn.Name = "ManagerProductBtn";
            this.ManagerProductBtn.Size = new System.Drawing.Size(192, 30);
            this.ManagerProductBtn.TabIndex = 4;
            this.ManagerProductBtn.Text = "Gerenciar Produto";
            this.ManagerProductBtn.UseVisualStyleBackColor = true;
            this.ManagerProductBtn.Click += new System.EventHandler(this.ManagerProductBtn_Click);
            // 
            // SearchProductTxt
            // 
            this.SearchProductTxt.Location = new System.Drawing.Point(12, 137);
            this.SearchProductTxt.Name = "SearchProductTxt";
            this.SearchProductTxt.Size = new System.Drawing.Size(431, 22);
            this.SearchProductTxt.TabIndex = 5;
            this.SearchProductTxt.TextChanged += new System.EventHandler(this.SearchProductTxt_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 118);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 16);
            this.label1.TabIndex = 6;
            this.label1.Text = "Pesquisar";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(748, 672);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.SearchProductTxt);
            this.Controls.Add(this.ManagerProductBtn);
            this.Controls.Add(this.DeleteProductBtn);
            this.Controls.Add(this.UpdateProductBtn);
            this.Controls.Add(this.registerNewProductBtn);
            this.Controls.Add(this.productsGV);
            this.Name = "MainForm";
            this.Text = "Principal";
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.productsGV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView productsGV;
        private System.Windows.Forms.Button registerNewProductBtn;
        private System.Windows.Forms.Button UpdateProductBtn;
        private System.Windows.Forms.Button DeleteProductBtn;
        private System.Windows.Forms.Button ManagerProductBtn;
        private System.Windows.Forms.TextBox SearchProductTxt;
        private System.Windows.Forms.Label label1;
    }
}

