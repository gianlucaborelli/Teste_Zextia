using Microsoft.Extensions.DependencyInjection;
using System;
using System.Windows.Forms;
using Zextia.DTOs;
using Zextia.Forms;
using Zextia.Services;

namespace Zextia
{
    public partial class MainForm : Form
    {
        private readonly IServiceProvider _serviceProvider;
        private readonly IProductService _productService;

        public MainForm(IProductService productService, IServiceProvider serviceProvider)
        {
            InitializeComponent();
            _serviceProvider = serviceProvider;
            _productService = productService ?? throw new ArgumentNullException(nameof(productService));
        }      

        private void LoadProducts()
        {
            var result = _productService.GetAll();

            if (result.Success)
            {
                productsGV.DataSource = result.Data;
            }
            else
            {
                MessageBox.Show(string.Join("\n", result.Errors), "Erro",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            LoadProducts();
        }

        private async void registerNewProductBtn_Click(object sender, EventArgs e)
        {
            using (var form = _serviceProvider.GetRequiredService<ProductEditorForm>())
            {
                await form.InitializeAsync(null);
                var result = form.ShowDialog();
                
                if (result == DialogResult.OK)
                {
                    LoadProducts();
                }
            }
        }

        private async void UpdateProductBtn_Click(object sender, EventArgs e)
        {
            using (var form = _serviceProvider.GetRequiredService<ProductEditorForm>())
            {
                var currentProduct = productsGV.SelectedRows.Count > 0
                    ? (ProductDto)productsGV.SelectedRows[0].DataBoundItem
                    : null;

                if (currentProduct == null)
                {
                    MessageBox.Show("Selecione um produto para editar.", "Informação",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                form.Text = "Editar produto";
                await form.InitializeAsync(currentProduct.Id);
                var result = form.ShowDialog();

                if (result == DialogResult.OK)
                {
                    LoadProducts();
                }
            }
        }

        private void ManagerProductBtn_Click(object sender, EventArgs e)
        {
            using (var form = _serviceProvider.GetRequiredService<ManagerProductSupplementForm>())
            {
                var currentProduct = productsGV.SelectedRows.Count > 0
                    ? (ProductDto)productsGV.SelectedRows[0].DataBoundItem
                    : null;

                if (currentProduct == null)
                {
                    MessageBox.Show("Selecione um produto para editar ou deixe em branco para criar um novo.", "Informação",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                form.Text = "Editar produto";
                form.InitializeAsync(currentProduct.Id);
                var result = form.ShowDialog();

                if (result == DialogResult.OK)
                {
                    LoadProducts();
                }
            }
        }

        private void productsGV_SelectionChanged(object sender, EventArgs e)
        {
            var hasSelection =
                productsGV.SelectedRows.Count > 0;

            UpdateProductBtn.Enabled = hasSelection;
            DeleteProductBtn.Enabled = hasSelection;
        }

        private void DeleteProductBtn_Click(object sender, EventArgs e)
        {
            var currentProduct = productsGV.SelectedRows.Count > 0
                    ? (ProductDto)productsGV.SelectedRows[0].DataBoundItem
                    : null;

            if (currentProduct == null)
            {
                MessageBox.Show("Selecione um produto para deletar.", "Informação",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            var confirmResult = MessageBox.Show($"Tem certeza que deseja deletar o produto '{currentProduct.Name}'?",
                "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (confirmResult == DialogResult.Yes)
            {
                var result = _productService.DeleteProduct(currentProduct.Id);
                if (result.Success)
                {
                    MessageBox.Show(result.Message ?? "Produto deletado com sucesso!", "Sucesso",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadProducts();
                }
                else
                {
                    MessageBox.Show(string.Join("\n", result.Errors), "Erro",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void SearchProductTxt_TextChanged(object sender, EventArgs e)
        {
            var searchTerm = SearchProductTxt.Text.Trim();
            if (string.IsNullOrEmpty(searchTerm))
            {
                LoadProducts();
            }
            else
            {
                var result = _productService.Find(searchTerm);
                if (result.Success)
                {
                    productsGV.DataSource = result.Data;
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
