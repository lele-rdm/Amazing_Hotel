using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Amazing_Hotel.Entities
{
    class Reserva
    {
        public List<Pessoa> Hospedes = new List<Pessoa>();
        public Suite Suite { get; set; }
        public int DiasReservados { get; set; }

        public Reserva(int diasReservados)
        {
            DiasReservados = diasReservados;
        }

        public void CadastrarHospedes(List<Pessoa> hospedes)
        {
            Hospedes = hospedes;
        }

        public void CadastrarSuite(Suite suite)
        {
            Suite = suite;
        }

        public int ObterQuantidadeHospedes()
        { 
            return Hospedes.Count;
        }

        public decimal CalcularValorTotal(decimal valorDiaria)
        {
            return DiasReservados * valorDiaria;
        }
    }
}
