using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trabajo_Practico_Tecnicatura
{
    public class Aerolinea
    {
        private string razonSocial;
        private string telefono;
        private string domicilio;

        public List<Vuelo> Vuelos { get; set; } = new List<Vuelo>();
        public string RazonSocial { get => razonSocial; set => razonSocial = value; }
        public string Telefono { get => telefono; set => telefono = value; }
        public string Domicilio { get => domicilio; set => domicilio = value; }
        

    }
}
