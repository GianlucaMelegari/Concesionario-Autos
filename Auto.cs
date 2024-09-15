using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Actividad_Integradora_1._2
{
    internal class Auto
    {
        List<Persona> listaPersonas;

        public string Patente { get; set; }
        public string Marca { get; set; }
        public string Modelo { get; set; }
        public string Año { get; set; }
        public decimal Precio { get; set; }
        public Persona Dueño { get; set; }
        public Auto() { }

        
    }
}
