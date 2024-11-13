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
            if (pck_alojamento.SelectedItem is Evento selectedEvento)
            {
                var evento = new Evento
                {
                    Adultos = (int)stp_adultos.Value,
                    Criancas = (int)stp_criancas.Value,
                    TipoEvento = selectedEvento.Descricao,
                    CheckIn = dtpck_checking.Date,
                    CheckOut = dtpck_checkout.Date,
                    ValorDiariaAdulto = selectedEvento.ValorDiariaAdulto,
                    ValorDiariaCrianca = selectedEvento.ValorDiariaCrianca,
                    ValorTotal = CalcularValorTotal((int)stp_adultos.Value, (int)stp_criancas.Value, selectedEvento, dtpck_checking.Date, dtpck_checkout.Date)
                };

                await Navigation.PushAsync(new ResumoEventoPage(evento));
            }
            else
            {
                await DisplayAlert("Erro", "Selecione um Evento.", "OK");
            }
        }

        private double CalcularValorTotal(int adultos, int criancas, Evento evento, DateTime checkIn, DateTime checkOut)
        {
            int totalNoites = (checkOut - checkIn).Days;
            double valorAdultos = adultos * evento.ValorDiariaAdulto;
            double valorCriancas = criancas * evento.ValorDiariaCrianca;
            return (valorAdultos + valorCriancas) * totalNoites;
        }

        private void dtpck_checking_DateSelected(object sender, DateChangedEventArgs e)
        {
            dtpck_checkout.MinimumDate = e.NewDate.AddDays(1);
            dtpck_checkout.MaximumDate = e.NewDate.AddMonths(6);
        }

        private void OnVoltarClicked(object sender, EventArgs e)
        {
            Navigation.PopAsync();
        }
    }
}