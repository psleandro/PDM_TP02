using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace PDM_TP02
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ProdutoForm : ContentPage
    {
        public ProdutoForm()
        {
            InitializeComponent();
        }

        private async void CriarProduto(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(inputId.Text) || String.IsNullOrEmpty(inputDescricao.Text) || String.IsNullOrEmpty(inputCategoria.Text) || String.IsNullOrEmpty(inputQuantidade.Text) || String.IsNullOrEmpty(inputPreco.Text))
            {
                DisplayAlert("ERROR", "Preencha todos os campos para criar o produto", "OK");
            } else
            {
                int id = int.Parse(inputId.Text);
                string descricao = inputDescricao.Text;
                string categoria = inputCategoria.Text;
                int quantidade = int.Parse(inputQuantidade.Text);
                decimal preco = decimal.Parse(inputPreco.Text);

                Produto newproduto = new Produto(id, descricao, categoria, quantidade, preco);

                var produtoDetalhe = new ProdutoDetalhe();
                produtoDetalhe.BindingContext = newproduto;
                await Navigation.PushAsync(produtoDetalhe);
            }
        }
    }
}