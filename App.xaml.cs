using AppHotel.Properties.Models;

namespace AppHotel
{
    public partial class App : Application
    {
        public List<HospedagemInfo> lista_chales = new List<HospedagemInfo>
        {
            new HospedagemInfo
            {
                Descricao = "Chalé Familiar",
                ValorDiariaAdulto = 110.0,
                ValorDiariaCrianca = 55.0
            },
            new HospedagemInfo
            {
                Descricao = "Chalé Casal",
                ValorDiariaAdulto = 90.0,
                ValorDiariaCrianca = 45.0
            },
            new HospedagemInfo
            {
                Descricao = "Camping",
                ValorDiariaAdulto = 50.0,
                ValorDiariaCrianca = 25.0
            }
        };

        public App()
        {
            InitializeComponent();
            MainPage = new AppShell();
        }
    }
}