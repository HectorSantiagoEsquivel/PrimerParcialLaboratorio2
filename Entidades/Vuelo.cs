using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Vuelo
    {
        static int contador = 1;
        public string identificadorVuelo { get; set; }
        
        public int asientosLibresEco { get; set; }
        public int asientosLibresPremium { get; set; }
        public double costoVueloBase { get; set; }
        public double duracionVuelo { get; set; }
        public Destino destino;
        public DateTime fechaDeSalida { get; set; }
        public DateTime fechaDeLlegada { get; set; }
        public EstadoVuelo estadoVueloAsignado { get; set; }
        public Nave nave;
        


        public List<Pasajero> listaPasajeros;

        public Vuelo instancia;
        

        public Vuelo(Nave naveAsignada,Destino destinoAsignado,DateTime fechaDeSalidaAsignada)
        {
            if(naveAsignada!=null && destinoAsignado!=null)
            {
                destino = destinoAsignado;
                nave = naveAsignada;
                fechaDeSalida = fechaDeSalidaAsignada;
                identificadorVuelo="BA-" + contador;
                contador++;
                listaPasajeros = new List<Pasajero>();
                Random rnd = new Random();
                asientosLibresPremium = (nave.cantAsientos * 20) / 100;
                asientosLibresEco = nave.cantAsientos - asientosLibresPremium;
                if(destino.tipoServicio== TipoServicio.internacional)
                {
                    duracionVuelo = rnd.Next(8,13);
                    costoVueloBase = duracionVuelo * 100;
                    
                }
                else
                {
                    duracionVuelo = rnd.Next(2, 5);
                    costoVueloBase = duracionVuelo * 50;
                }
                
                
                fechaDeLlegada=fechaDeSalida.AddHours(duracionVuelo);

                listaPasajeros = new List<Pasajero>();

                estadoVueloAsignado = EstadoVuelo.Programado;
                instancia = this;
            }

        }

        public enum EstadoVuelo
        {
            Programado,
            Volando,
            Finalizado

        }


    }
}
