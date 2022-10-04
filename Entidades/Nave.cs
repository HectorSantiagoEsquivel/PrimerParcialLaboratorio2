using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Nave
    {
        public int cantAsientos { get; set; }
        public string matricula { get; set; }
        public bool asignadoAVuelo { get; set; }
        public double horasDeVueloTotal;
        public List<Vuelo> vuelosRealizados;

        public Nave instancia;

        public Nave(string matriculaAsignada, int cantAsientosAsignados, bool asignadoAVueloIngresado)
        {
            cantAsientos = cantAsientosAsignados;
            matricula = matriculaAsignada;
            asignadoAVuelo = asignadoAVueloIngresado;
            horasDeVueloTotal = 0;
            vuelosRealizados = new List<Vuelo>();
            instancia = this;
        }
        public static List<Nave> InicializarNaves()
        {

            List<Nave> ListaNaves = new List<Nave> {
               new Nave("BA1816",170,false),
               new Nave("BA1946",170,false),
               new Nave("BA1810",170,false),
               new Nave("BA1986",170,false),
               new Nave("BA6231",170,false),
               new Nave("BA6233",170,false),
               new Nave("BA6235",170,false),

            };
            return ListaNaves;
        }
    }
}

