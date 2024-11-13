using AppHotel.Properties.Models;

namespace AppHotel.Views
{
    public partial class ResumoEventoPage : ContentPage
    {
        public ResumoEventoPage(Evento evento)
        {
            InitializeComponent();

            // Exibe os dados na interface
            lblAdultos.Text = evento.Adultos.ToString();
            lblCriancas.Text = evento.Criancas.ToString();
            lblCheckIn.Text = evento.CheckIn.ToString("dd/MM/yyyy");
            lblCheckOut.Text = evento.CheckOut.ToString("dd/MM/yyyy");
            lblDias.Text = $"{(evento.CheckOut - evento.CheckIn).Days} noite(s)";
            lblValorTotal.Text = $"R$ {evento.ValorTotal:F2}";
        }

        private void OnVoltarClicked(object sender, EventArgs e)
        {
            Navigation.PopAsync();
        }

        private void OnConfirmarReservaClicked(object sender, EventArgs e)
        {
            DisplayAlert("Confirmação", "Reserva confirmada com sucesso!", "OK");
            Navigation.PopToRootAsync();
        }
    }
}
