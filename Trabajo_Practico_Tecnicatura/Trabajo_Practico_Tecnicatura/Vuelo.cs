using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trabajo_Practico_Tecnicatura
{
    public class Vuelo
    {
        private string codigo;
        private DateTime fechaSalida;
        private DateTime fechaLlegada;
        private string piloto;
        private string copiloto;
        private int capacidadMaxima;
        private int pasajerosActuales;

        public string Codigo { get => codigo; set => codigo = value; }
        public DateTime FechaSalida { get => fechaSalida; set => fechaSalida = value; }
        public DateTime FechaLlegada { get => fechaLlegada; set => fechaLlegada = value; }
        public string Piloto { get => piloto; set => piloto = value; }
        public string Copiloto { get => copiloto; set => copiloto = value; }
        public int CapacidadMaxima { get => capacidadMaxima; set => capacidadMaxima = value; }
        public int PasajerosActuales { get => pasajerosActuales; set => pasajerosActuales = value; }

        public double PorcentajeOcupacion()
        {
            return(double)pasajerosActuales / capacidadMaxima * 100;
        }
    }
}
