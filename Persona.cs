using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Actividad_Integradora_1._2
{
    internal class Persona
    {
        List<Auto> la;
        public Persona() { la = new List<Auto>(); }


        public Persona(string pDNI, string pNombre, string pApellido): this() 
        { 
            DNI = pDNI;
            Nombre = pNombre;
            Apellido = pApellido;
        }


        public string DNI { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public Persona ClonPersona()
        {
            return new Persona(DNI, Nombre, Apellido);
        }

        public void AgregarAuto(Auto pAuto) { la.Add(pAuto.ClonAuto()); }
        /*
        public void BorrarAuto(Auto pAuto) 
        {
            Auto p = la.Find(x => x.Patente == pAuto.Patente);
            if (p != null) { la.Remove(p); }
            //la.Remove(pAuto);  
            //la.Remove(la.Find(x => x.Patente == pAuto.Patente));
        }
        //public List<Auto> ListaDeAutos() { return la; }

        
        public object ListaDeAutos()
        {
            return (from p in la select new { Patente = p.Patente, Marca = p.Marca, Modelo = p.Modelo, Año = p.Modelo, Precio = p.Precio, Dueño = p.Dueño }).ToList();
        }*/

    }
}
