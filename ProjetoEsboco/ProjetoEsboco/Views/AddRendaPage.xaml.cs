using ProjetoEsboco.Models;
using ProjetoEsboco.Services;
using System;
using System.Data;
using System.Linq;
using Xamarin.Forms;

namespace ProjetoEsboco.Views
{
    public partial class AddRendaPage : ContentPage
    {
        public AddRendaPage()
        {
            InitializeComponent();
        }

        private void Button_Clicked(object sender, System.EventArgs e)
        {

        }

        private void ButtonCancelar_Clicked(object sender, System.EventArgs e)
        {
            etValorRendaAdd.Text = string.Empty;
            pckTipoRenda = new Picker { Title = "Select a monkey", TitleColor = Color.Red };
            swtFixo.IsToggled = false;
            dpDataCriacao.Date = DateTime.Now;
        }

        private void ButtonSalvar_Clicked(object sender, EventArgs e)
        {
            var renda = new Renda
            {
                Valor = Convert.ToDouble(etValorRendaAdd.Text),
                Tipo = pckTipoRenda.Items.First(),
                Fixo = swtFixo.IsToggled,
                DataCriacao = dpDataCriacao.Date
            };
            App.Database.SaveRendaAsync(renda);


            etValorRendaAdd.Text = string.Empty;
            pckTipoRenda = new Picker { Title = "Select a monkey", TitleColor = Color.Red };
            swtFixo.IsToggled = false;
            dpDataCriacao.Date = DateTime.Now;

        }
    }
}