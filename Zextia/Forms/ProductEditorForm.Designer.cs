namespace Zextia.Forms
{
    partial class ProductEditorForm
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
            this.ProductNameTxt = new System.Windows.Forms.TextBox();
            this.ProductCodeTxt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SaveNewProductBtn = new System.Windows.Forms.Button();
            this.ProductDescriptionTxt = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ProductNameTxt
            // 
            this.ProductNameTxt.Location = new System.Drawing.Point(75, 12);
            this.ProductNameTxt.Name = "ProductNameTxt";
            this.ProductNameTxt.Size = new System.Drawing.Size(313, 22);
            this.ProductNameTxt.TabIndex = 0;
            this.ProductNameTxt.TextChanged += new System.EventHandler(this.ProductNameTxt_TextChanged);
            // 
            // ProductCodeTxt
            // 
            this.ProductCodeTxt.Location = new System.Drawing.Point(75, 47);
            this.ProductCodeTxt.Name = "ProductCodeTxt";
            this.ProductCodeTxt.Size = new System.Drawing.Size(313, 22);
            this.ProductCodeTxt.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Nome";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Código";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 190);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "Cancelar";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // SaveNewProductBtn
            // 
            this.SaveNewProductBtn.Location = new System.Drawing.Point(311, 190);
            this.SaveNewProductBtn.Name = "SaveNewProductBtn";
            this.SaveNewProductBtn.Size = new System.Drawing.Size(75, 23);
            this.SaveNewProductBtn.TabIndex = 5;
            this.SaveNewProductBtn.Text = "Salvar";
            this.SaveNewProductBtn.UseVisualStyleBackColor = true;
            this.SaveNewProductBtn.Click += new System.EventHandler(this.SaveNewProductBtn_Click);
            // 
            // ProductDescriptionTxt
            // 
            this.ProductDescriptionTxt.Location = new System.Drawing.Point(75, 84);
            this.ProductDescriptionTxt.Multiline = true;
            this.ProductDescriptionTxt.Name = "ProductDescriptionTxt";
            this.ProductDescriptionTxt.Size = new System.Drawing.Size(313, 100);
            this.ProductDescriptionTxt.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(0, 87);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 16);
            this.label3.TabIndex = 7;
            this.label3.Text = "Descrição";
            // 
            // RegisterNewProductForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(398, 225);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.ProductDescriptionTxt);
            this.Controls.Add(this.SaveNewProductBtn);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ProductCodeTxt);
            this.Controls.Add(this.ProductNameTxt);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "RegisterNewProductForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Registrar novo produto";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox ProductNameTxt;
        private System.Windows.Forms.TextBox ProductCodeTxt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button SaveNewProductBtn;
        private System.Windows.Forms.TextBox ProductDescriptionTxt;
        private System.Windows.Forms.Label label3;
    }
}