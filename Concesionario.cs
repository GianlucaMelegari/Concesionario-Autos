using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Actividad_Integradora_1._2
{
    internal class Concesionario
    {
        List<Persona> lp;
        List<Auto> la;
        public Concesionario() { lp = new List<Persona>(); la = new List<Auto>(); }


        //Persona
        public void AgregarPersona(Persona pPersona)
        {
            if (lp == null) lp = new List<Persona>();
            lp.Add(pPersona.ClonPersona());
        }
        public void BorrarPersona(Persona pPersona)
        {
            if (lp != null)
            {
                Persona p = lp.Find(x => x.DNI == pPersona.DNI);
                if (p != null) { lp.Remove(p); }
            }
        }
        public List<Persona> ListaDePersonas()
        {
            return lp?.Select(p => p.ClonPersona()).ToList() ?? new List<Persona>();
        }
        /*public object ListaDePersonas() 
        {
            return (from p in lp select new { DNI = p.DNI, Nombre = p.Nombre, Apellido = p.Apellido }).ToList() ; 
        }*/

        //Auto
        public void AgregarAuto(Auto pAuto)
        {
            if (la == null) la = new List<Auto>();
            la.Add(pAuto.ClonAuto());
        }

        public void BorrarAuto(Auto pAuto)
        {
            if (la != null)
            {
                Auto a = la.Find(x => x.Patente == pAuto.Patente);
                if (a != null) { la.Remove(a); }
            }
        }

        public List<Auto> ListaDeAutos()
        {
            return la?.Select(a => a.ClonAuto()).ToList();
        }
        /*public object ListaDeAutos()
        {
            return (from p in la select new { Patente = p.Patente, Marca = p.Marca, Modelo = p.Modelo, Año = p.Modelo, Precio = p.Precio, Dueño = p.Dueño }).ToList();
        }*/
    }
}
