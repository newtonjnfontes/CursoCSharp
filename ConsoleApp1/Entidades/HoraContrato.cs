using System;
using System.Collections.Generic; // namespace da classe list
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Entidades
{
    class HoraContrato
    {
        public DateTime Data { get; set; }
        public double ValorPorHora { get; set; }
        public int Horas { get; set; }

        public HoraContrato()
        {
        }

        public HoraContrato(DateTime data, double valorPorHora, int horas)
        {
            Data = data;
            ValorPorHora = valorPorHora;
            Horas = horas;
        }

        public double TotalValor()
        {
            return Horas * ValorPorHora;
        }
    }
}
