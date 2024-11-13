
namespace AppHotel.Views
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            try
            {
                Navigation.PushAsync(new ContratacaoHospedagem());
            }
                catch (Exception ex)
            {
                DisplayAlert("Ops", ex.Message, "OK");
            }
            }
        }
    }
