﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace PDM_TP02
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ProdutoDetalhe : ContentPage
    {
        public ProdutoDetalhe()
        {
            InitializeComponent();
        }

        private async void btnVoltar_Clicked(object sender, EventArgs e)
        {
            await Navigation.PopToRootAsync();
        }
    }
}