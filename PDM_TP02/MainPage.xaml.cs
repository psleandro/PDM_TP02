using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace PDM_TP02
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }
        private async void btnEstiloPadrao_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new EstiloPadrao());
        }

        private async void btnEstiloDinamico_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new RelogioViewPage());
        }

        private async void btnEstiloEventTrigger_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new EventTrigger());
        }

        private async void btnEstiloGlobal_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new ViewSimples());
        }

        private async void btnHome_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new ContatoForm());
        }

        private void btnMessagingCenter_Clicked(object sender, EventArgs e)
        {
            DisplayAlert("SUCESSO", "botrao padrao", "OK");
        }

        private async void btnSimples_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new ProdutoForm());
        }

        private void btnClasseComplexa_Clicked(object sender, EventArgs e)
        {
            DisplayAlert("SUCESSO", "botrao padrao", "OK");
        }

        private void btnProduto_Clicked(object sender, EventArgs e)
        {
            DisplayAlert("SUCESSO", "botrao padrao", "OK");
        }

    }
}
