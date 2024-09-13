using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Amazing_Hotel.Entities;

namespace Amazing_Hotel.Entities
{
    class Suite
    {
        public string TipoSuite { get; set; }
        public int Capacidade {  get; set; }
        public decimal ValorDiaria { get; set; }

        public Suite(string tipoSuite, int capacidade, decimal valorDiaria)
        {
            TipoSuite = tipoSuite;
            Capacidade = capacidade;
            ValorDiaria = valorDiaria;
        }
        public void MostrarMenu()
        {
            Console.WriteLine(" ------------------------------");
            Console.WriteLine("\n     Suítes Disponíveis   \n");
            Console.WriteLine("   1 - Premium: R30 a diária");
            Console.WriteLine("   2 - Medium: R20 a diária");
            Console.WriteLine("   3 - Basic: R10 a diária\n");
            Console.WriteLine(" ------------------------------");
        }
    }
}
