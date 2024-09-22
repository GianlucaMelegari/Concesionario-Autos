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
        public Concesionario()
        {
            lp = new List<Persona>();
            la = new List<Auto>();
            la.AddRange(new Auto[]{new Auto("AB123GF","Fiat","Cronos","2020",10000) ,
                                  new Auto("AG992AA","BMW","325","2030",50000) ,
                                  new Auto("AF882AB","Ford","Maveric","2024",40000)});
        }

        public void AgregarPersona(Persona pPersona)
        { 
            lp.Add(pPersona.ClonPersona()); 
            //la.Remove(la.Find(x => x.Patente==pAuto.Patente));
            //lp.Add(pPersona.ClonPersona());
        } 
         
        public void BorrarPersona(Persona pPersona)
        {
            Persona p = lp.Find(x => x.DNI == pPersona.DNI);
            if (p != null) lp.Remove(p);
            la.ForEach(a => { if (a.RetornaDueño().DNI == pPersona.DNI) a.Dueño = null; });
        }

        public bool ValidarDNI(Persona pPersona) => lp.Exists(x => x.DNI == pPersona.DNI);

        public void Asignar(Persona pPersona, Auto pAuto)
        {
            try
            {
                var auto = la.Find(a => a.Patente == pAuto.Patente);
                if (auto == null) throw new Exception("No existe el auto a asignar !!!");
                if (auto.RetornaDueño() != null) throw new Exception("No se puede asignar el auto porque ya posee un dueño !!!");
                var persona = lp.Find(p => p.DNI == pPersona.DNI);
                if (persona == null) throw new Exception("No existe la persona !!!");
                persona.AgregarAuto(auto);  //ASOCIACION BIDIRECCIONAL
                auto.Dueño = persona;       //ASOCIACION BIDIRECCIONAL
            }
            catch (Exception ex) { throw ex; }
        }
        public object ListaDePersonas()
        {
            return (from p in lp select new { DNI = p.DNI, Nombre = p.Nombre, Apellido = p.Apellido }).ToList();
        }
        public object ListaDeAutos()
        {
            return (from a in la select new { Patente = a.Patente, Marca = a.Marca, Modelo = a.Modelo, Año = a.Año, Precio = a.Precio }).ToList();

        }

        public List<Auto> ListaDeAutosUnaPersona(Persona pPersona)
        {
            try
            {
                var persona = lp.Find(p => p.DNI == pPersona.DNI);
                if (persona == null) throw new Exception("No existe la persona !!!");
                return persona.ListaDeAutos();
            }
            catch (Exception ex) { throw ex; }
        }

        public object ListaDeAutosyDuenos()
        {
            return (from a in la
                    select new
                    {
                        Patente = a.Patente,
                        Marca = a.Marca,
                        Modelo = a.Modelo,
                        Axo = a.Año,
                        Precio = a.Precio,
                        DNI = a.RetornaDueño() != null ? a.RetornaDueño().DNI : "---",
                        ApellidoNombre = a.RetornaDueño() != null ? a.RetornaDueño().Apellido + ", " + a.RetornaDueño().Nombre : "---"
                    }).ToList();

        }

    }
}
