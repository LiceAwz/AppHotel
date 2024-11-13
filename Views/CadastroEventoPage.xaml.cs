using AppHotel.Properties.Models;
using System;

namespace AppHotel.Views
{
    public partial class CadastroEventoPage : ContentPage
    {
        private App PropriedadesApp;

        public CadastroEventoPage()
        {
            InitializeComponent();

            PropriedadesApp = (App)Application.Current;
            pck_alojamento.ItemsSource = PropriedadesApp.lista_evento;
            dtpck_checking.MinimumDate = DateTime.Now;
            dtpck_checking.MaximumDate = DateTime.Now.AddMonths(1);
            dtpck_checkout.MinimumDate = dtpck_checking.Date.AddDays(1);
            dtpck_checkout.MaximumDate = dtpck_checking.Date.AddMonths(6);
        }

        private async void OnAvancarClicked(object sender, EventArgs e)
        {
            if (pck_alojamento.SelectedItem is HospedagemInfo selectedChale)
            {
                var hospedagemInfo = new HospedagemInfo
                {
                    Adultos = (int)stp_adultos.Value,
                    Criancas = (int)stp_criancas.Value,
                    TipoAcomodacao = selectedChale.Descricao,
                    CheckIn = dtpck_checking.Date,
                    CheckOut = dtpck_checkout.Date,
                    ValorDiariaAdulto = selectedChale.ValorDiariaAdulto,
                    ValorDiariaCrianca = selectedChale.ValorDiariaCrianca,
                    ValorTotal = CalcularValorTotal((int)stp_adultos.Value, (int)stp_criancas.Value, selectedChale, dtpck_checking.Date, dtpck_checkout.Date)
                };

                await Navigation.PushAsync(new HospedagemContratada(hospedagemInfo));
            }
            else
            {
                await DisplayAlert("Erro", "Selecione uma acomodação.", "OK");
            }
        }

        private double CalcularValorTotal(int adultos, int criancas, HospedagemInfo chale, DateTime checkIn, DateTime checkOut)
        {
            int totalNoites = (checkOut - checkIn).Days;
            double valorAdultos = adultos * chale.ValorDiariaAdulto;
            double valorCriancas = criancas * chale.ValorDiariaCrianca;
            return (valorAdultos + valorCriancas) * totalNoites;
        }

        private void dtpck_checking_DateSelected(object sender, DateChangedEventArgs e)
        {
            dtpck_checkout.MinimumDate = e.NewDate.AddDays(1);
            dtpck_checkout.MaximumDate = e.NewDate.AddMonths(6);
        }
    }
}