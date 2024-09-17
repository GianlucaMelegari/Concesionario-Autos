using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Actividad_Integradora_1._2
{
    internal class Auto
    {
        List<Persona> la;
        public Auto() { la = new List<Persona>(); }

        public Auto(string pPatente, string pMarca, string pModelo, string pAño, decimal pPrecio, Persona pDueño)
        {
            this.Patente = pPatente;    
            this.Marca = pMarca;
            this.Modelo = pModelo;
            this.Año = pAño;
            this.Precio = pPrecio;
            this.Dueño = pDueño;
        }

        public string Patente { get; set; }
        public string Marca { get; set; }
        public string Modelo { get; set; }
        public string Año { get; set; }
        public decimal Precio { get; set; }
        public Persona Dueño { get; set; }

        public Auto ClonAuto()
        {
            return new Auto(Patente, Marca, Modelo, Año, Precio, Dueño);
        }


    }
}
