using AppHotel.Properties.Models;
using System.Reflection;

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

         public List<Evento> lista_evento = new List<Evento>
        {
            new Evento
            {
                Descricao = "Casamento",
                ValorDiariaAdulto = 300.0,
                ValorDiariaCrianca = 170.0
            },
           
            new Evento
            {
                Descricao = "Aniversario",
                ValorDiariaAdulto = 150.0,
                ValorDiariaCrianca = 75.0
            }

        };

        public App()
        {
            InitializeComponent();
            MainPage = new AppShell();
        }
    }
}