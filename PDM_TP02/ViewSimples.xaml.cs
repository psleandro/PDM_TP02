using System;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace PDM_TP02
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ViewSimples : ContentPage
    {
        public ObservableCollection<string> Items { get; set; }

        public ViewSimples()
        {
            InitializeComponent();

            Items = new ObservableCollection<string>
            {
                "Desenvolvimento de aplicativos Xamarin",
                "Introdução a Big Data & Analytics",
                "Certificação TOGAF Nível 1",
            };

            MyListView.ItemsSource = Items;
        }

        async void Handle_ItemTapped(object sender, ItemTappedEventArgs e)
        {
            if (e.Item == null)
                return;

            await DisplayAlert("Item Tapped", "An item was tapped.", "OK");

            //Deselect Item
            ((ListView)sender).SelectedItem = null;
        }
    }
}
