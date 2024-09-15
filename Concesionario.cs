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
        public Concesionario() { lp = new List<Persona>(); }

        public void AgregarPersona(Persona pPersona) { lp.Add(pPersona.ClonPersona()); }
        public void BorrarPersona(Persona pPersona)
        {
            Persona p = lp.Find(x => x.DNI == pPersona.DNI);
            if(p != null) {lp.Remove(p); }
        }
        public object ListaDePersonas() 
        {
            return (from p in lp select new { DNI = p.DNI, Nombre = p.Nombre, Apellido = p.Apellido }).ToList() ; 
        }

    }
}
