using System;
using Xamarin.Forms;

namespace ProjetoEsboco.Views
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        protected override async void OnAppearing()
        {
            base.OnAppearing();
            double valorTotal = 0.0;
            var rendaTotal = await App.Database.GetRendaAsync();
            foreach (var ren in rendaTotal)
            {
                valorTotal = ren.Valor + valorTotal;
            }
            etValorRendaTotal.Text = valorTotal.ToString("C", System.Globalization.CultureInfo.CreateSpecificCulture("pt-BR"));
        }
    }
}