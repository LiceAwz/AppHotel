using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppHotel.Properties.Models
{
    public class Evento
    {
        public int Adultos { get; set; }
        public int Criancas { get; set; }
        public string TipoEvento { get; set; } = string.Empty;
        public DateTime CheckIn { get; set; }
        public DateTime CheckOut { get; set; }
        public String Descricao { get; set; } = string.Empty;
        public int Dias { get; set; }
        public double ValorDiariaAdulto { get; set; }
        public double ValorDiariaCrianca { get; set; }
        public double ValorTotal { get; set; }
    }
}