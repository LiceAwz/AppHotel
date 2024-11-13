using AppHotel.Properties.Models;

namespace AppHotel.Views
{
    public partial class HospedagemContratada : ContentPage
    {
        public HospedagemContratada(HospedagemInfo hospedagemInfo)
        {
            InitializeComponent();

            // Exibe os dados na interface
            lblAdultos.Text = hospedagemInfo.Adultos.ToString();
            lblCriancas.Text = hospedagemInfo.Criancas.ToString();
            lblCheckIn.Text = hospedagemInfo.CheckIn.ToString("dd/MM/yyyy");
            lblCheckOut.Text = hospedagemInfo.CheckOut.ToString("dd/MM/yyyy");
            lblDias.Text = $"{(hospedagemInfo.CheckOut - hospedagemInfo.CheckIn).Days} noite(s)";
            lblValorTotal.Text = $"R$ {hospedagemInfo.ValorTotal:F2}";
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