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
    public partial class ContatoForm : ContentPage
    {
        public ContatoForm()
        {
            InitializeComponent();
        }

        private async void CriarContato(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(inputNome.Text) || String.IsNullOrEmpty(inputIdade.Text) || String.IsNullOrEmpty(inputProfissao.Text) || String.IsNullOrEmpty(inputPais.Text))
            {
                DisplayAlert("ERROR", "Preencha todos os campos para criar o contato", "OK");
            } else
            {
                string name = inputNome.Text;
                int idade = int.Parse(inputIdade.Text);
                string profissao = inputProfissao.Text;
                string pais = inputPais.Text;
                Contato newcont = new Contato(name, idade, profissao, pais);

                var detalhePage = new DetalheView();
                detalhePage.BindingContext = newcont;
                await Navigation.PushAsync(detalhePage);

            }
        }
    }
}