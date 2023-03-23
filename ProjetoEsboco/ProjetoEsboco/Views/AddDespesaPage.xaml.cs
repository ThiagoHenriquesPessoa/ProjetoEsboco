using ProjetoEsboco.ViewModels;
using System;
using Xamarin.Forms;

namespace ProjetoEsboco.Views
{
    public partial class AddDespesaPage : ContentPage
    {
        public AddDespesaPage()
        {
            InitializeComponent();
        }

        private void ButtonCancelar_Clicked(object sender, System.EventArgs e)
        {
            etValorDespesaAdd.Text = string.Empty;
            pckTipoDespesa.Title = string.Empty;
            swtFixoDespesa.IsToggled = false;
            pckCartaoCredito.Title = string.Empty;
            etQtdeParcelaAdd.Text = string.Empty;
            dpDataCriacaoDespesa.Date = DateTime.Now;
        }
    }
}