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
        Persona dueño;

        public Auto(string pPatente)
        { Patente=pPatente; }


        public Auto(string pPatente,string pMarca,string pModelo,string pAxo,decimal pPrecio) : this(pPatente)
        { Marca=pMarca;Modelo=pModelo;Año=pAxo;Precio=pPrecio; }


        public string Patente { get; set; }
        public string Marca { get; set; }
        public string Modelo { get; set; }
        public string Año { get; set; }
        public decimal Precio { get; set; }
        public Persona Dueño { set { dueño = value; } }
        public Persona RetornaDueño() { return dueño; }


    }
}
