using Superpower.Model;
using System;
using System.Threading.Tasks;
using System.Windows.Forms;
using Zextia.DTOs;
using Zextia.Services;

namespace Zextia.Forms
{
    public partial class ProductEditorForm : Form
    {
        private bool _isEditMode;
        private readonly IProductService _productService;
        private ProductDto _product;
        private readonly BindingSource _bindingSource;
        public ProductEditorForm(IProductService productService)
        {   
            InitializeComponent();
            _productService = productService;
            _bindingSource = new BindingSource();
        }

        public async Task InitializeAsync(Guid? productId)
        {
            if (productId != null)
            {
                var result = _productService.GetById(productId.Value);
                if(result.Success)
                {
                    _product = result.Data;
                    BindProduct();
                    _isEditMode = true;
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
                _product = new ProductDto();
                _isEditMode = false;
                BindProduct();
            }
        }

        public void BindProduct()
        {
            _bindingSource.DataSource = _product;

            ProductNameTxt.DataBindings.Add(
                "Text",
                _bindingSource,
                nameof(ProductDto.Name),
                false,
                DataSourceUpdateMode.OnPropertyChanged);

            ProductCodeTxt.DataBindings.Add(
                "Text",
                _bindingSource,
                nameof(ProductDto.Code),
                true,
                DataSourceUpdateMode.OnPropertyChanged);

            ProductDescriptionTxt.DataBindings.Add(
                "Text",
                _bindingSource,
                nameof(ProductDto.DetailDescription),
                true,
                DataSourceUpdateMode.OnPropertyChanged);
        }

        private void SaveNewProductBtn_Click(object sender, EventArgs e)
        {
            var result = _isEditMode
                ? _productService.UpdateProduct(_product)
                : _productService.CreateProduct(_product);

          
            if (result.Success) 
            {
                MessageBox.Show(result.Message ?? "Produto salvo com sucesso!", "Sucesso",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);
                DialogResult = DialogResult.OK;
                Close();          
            }
            else
            {
                MessageBox.Show(string.Join("\n", result.Errors), "Erro",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ProductNameTxt_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
