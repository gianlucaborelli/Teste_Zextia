using System;
using System.Windows.Forms;
using Zextia.DTOs;
using Zextia.Services;

namespace Zextia.Forms
{
    public partial class ManagerProductSupplementForm : Form
    {
        private ProductDto _product { get; set; }

        private readonly IProductService _productService;

        public ManagerProductSupplementForm(IProductService productService)
        {            
            InitializeComponent();
            _productService = productService ?? throw new ArgumentNullException(nameof(productService));
        }

        public void InitializeAsync(Guid? productId)
        {
            if (productId != null)
            {
                var result = _productService.GetById(productId.Value);
                if (result.Success)
                {
                    _product = result.Data;    
                    ProductNameLbl.Text = _product.Name;
                    ProductDescriptionLbl.Text = _product.DetailDescription;
                    productSupplementsDG.DataSource = result.Data.Supplements;
                }
                else
                {
                    MessageBox.Show(string.Join("\n", result.Errors), "Erro",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    DialogResult = DialogResult.Cancel;
                    Close();
                }
            }
            else
            {
                MessageBox.Show("Produto não encontrado.", "Erro",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                DialogResult = DialogResult.Cancel;
                Close();
            }
        }

        private void CreateNewSupplementBtn_Click(object sender, EventArgs e)
        {
            using (var form = new SupplementEditorForm(_productService))
            {
                form.InitializeAsync(_product.Id, null);
                form.Text = "Criar Novo Suplemento";
                var result = form.ShowDialog();
                if (result == DialogResult.OK)
                {
                    InitializeAsync(_product.Id);
                }
            }
        }

        private void UpdateSupplementBtn_Click(object sender, EventArgs e)
        {
            var currentSupplement = productSupplementsDG.SelectedRows.Count > 0
                    ? (ProductSupplementDto)productSupplementsDG.SelectedRows[0].DataBoundItem
                    : null;

            using (var form = new SupplementEditorForm(_productService))
            {
                form.InitializeAsync(_product.Id, currentSupplement?.Id);
                form.Text = "Editar Suplemento";
                var result = form.ShowDialog();
                if (result == DialogResult.OK)
                {
                    InitializeAsync(_product.Id);
                }
            }
        }

        private void DeleteSupplementBtn_Click(object sender, EventArgs e)
        {
            var currentSupplement = productSupplementsDG.SelectedRows.Count > 0
                    ? (ProductSupplementDto)productSupplementsDG.SelectedRows[0].DataBoundItem
                    : null;

            if (currentSupplement != null)
            {
                var confirmResult = MessageBox.Show("Tem certeza que deseja excluir este suplemento?", "Confirmar Exclusão",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (confirmResult == DialogResult.Yes)
                {
                    var result = _productService.DeleteSupplement(_product.Id, currentSupplement.Id);
                    if (result.Success)
                    {
                        InitializeAsync(_product.Id);
                    }
                    else
                    {
                        MessageBox.Show(string.Join("\n", result.Errors), "Erro",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }

        }
    }
}
