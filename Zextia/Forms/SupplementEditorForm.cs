using System;
using System.Linq;
using System.Windows.Forms;
using Zextia.DTOs;
using Zextia.Services;

namespace Zextia.Forms
{
    public partial class SupplementEditorForm : Form
    {
        private readonly IProductService _productService;
        private readonly BindingSource _bindingSource;
        private ProductDto _product;
        private ProductSupplementDto _supplement;
        private bool _isEditMode;

        public SupplementEditorForm(IProductService productService)
        {
            InitializeComponent();
            _productService = productService ?? throw new ArgumentNullException(nameof(productService));
            _bindingSource = new BindingSource();
        }

        public void InitializeAsync(Guid? productId, Guid? supplementId)
        {
            if(productId == null)
            {
                MessageBox.Show("Produto não encontrado.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Close();
                return;
            }

            var result = _productService.GetById(productId.Value);
            if (result.Success)
            {
                _product = result.Data;
                ProductNameLbl.Text = _product.Name;
                ProductDescriptionLbl.Text = _product.DetailDescription;

                _isEditMode = supplementId != null;
                if (_isEditMode)
                {
                    _supplement = _product.Supplements.FirstOrDefault(s => s.Id == supplementId.Value);
                    if (_supplement != null)
                    {
                        BindSupplement();
                    }
                    else
                    {
                        MessageBox.Show("Lote não encontrado.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        Close();
                    }
                }
                else
                {
                    _supplement = new ProductSupplementDto 
                    { 
                        Id = Guid.NewGuid(), 
                        ProductId = _product.Id, 
                        CreatedAt = DateTime.UtcNow 
                    };
                    BindSupplement();
                }
            }            
        }

        private void BindSupplement()
        {
            _bindingSource.DataSource = _supplement;
            SupplementBatchTxt.DataBindings.Add(
                "Text",
                _bindingSource,
                nameof(ProductSupplementDto.Batches),
                false,
                DataSourceUpdateMode.OnPropertyChanged);
        }

        private void SaveBtn_Click(object sender, EventArgs e)
        {
            var result = _isEditMode 
                     ? _productService.UpdateSupplement(_product.Id, _supplement)
                     : _productService.AddSupplementToProduct(_product.Id, _supplement);

            if(result.Success)
            {
                MessageBox.Show("Operação realizada com sucesso.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                DialogResult = DialogResult.OK;
                Close();
            }
            else
            {
                MessageBox.Show("Ocorreu um erro ao salvar o suplemento.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CancelBtn_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }
    }
}
