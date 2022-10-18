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

        static public void actualizarVuelo(List<Vuelo> listaVuelos, List<Pasajero> listaPasajeros)
        {
            foreach (var Vuelo in listaVuelos)
            {
                var diferenciaSalida = Vuelo.fechaDeSalida - DateTime.Now;
                var diferenciaLlegada = Vuelo.fechaDeLlegada - DateTime.Now;
                if (diferenciaSalida.TotalSeconds <= 0 && Vuelo.estadoVueloAsignado == Vuelo.EstadoVuelo.Programado)
                {
                    Vuelo.estadoVueloAsignado = Vuelo.EstadoVuelo.Volando;
                    Vuelo.destino.acumuladorFacturacion = Vuelo.destino.acumuladorFacturacion +
                        (Vuelo.costoVueloBase * Vuelo.listaPasajeros.Where(Pasajero => Pasajero.clase == Clase.Economica).Count() +
                        ((Vuelo.costoVueloBase * 15) / 100 + Vuelo.costoVueloBase) * Vuelo.listaPasajeros.Where(Pasajero => Pasajero.clase == Clase.Premium).Count());
                }
                if (diferenciaLlegada.TotalSeconds <= 0 && Vuelo.estadoVueloAsignado == Vuelo.EstadoVuelo.Volando)
                {
                    Vuelo.estadoVueloAsignado = Vuelo.EstadoVuelo.Finalizado;
                    Vuelo.nave.horasDeVueloTotal = Vuelo.nave.horasDeVueloTotal + Vuelo.duracionVuelo;
                    Vuelo.nave.vuelosRealizados.Add(Vuelo);
                    Vuelo.destino.vuelosRealizados.Add(Vuelo);
                    Vuelo.nave.asignadoAVuelo = false;
                    foreach (var PasajeroB in listaPasajeros)
                    {
                        if (Vuelo.listaPasajeros.Exists(PasajeroA => PasajeroA.dni == PasajeroB.dni))
                        {
                            listaPasajeros.Remove(PasajeroB);
                        }
                    }
                }
            }

        }

        static public void actualizarAsientosDisponibles(Vuelo vueloIngresado, Clase claseIngresada)
        {
            if (claseIngresada == Clase.Premium)
            {
                vueloIngresado.asientosLibresPremium = vueloIngresado.asientosLibresPremium - 1;
            }
            else
            {
                vueloIngresado.asientosLibresEco = vueloIngresado.asientosLibresEco - 1;
            }

        }

        static public bool confirmarAsienstosDisponibles(Vuelo vueloIngresado,Clase claseIngresada)
        {
            if((vueloIngresado.asientosLibresEco>1&&claseIngresada==Clase.Economica)|| (vueloIngresado.asientosLibresPremium > 1 && claseIngresada == Clase.Premium))
            {
                return true;
            }
            return false;
        }

        public enum EstadoVuelo
        {
            Programado,
            Volando,
            Finalizado

        }
    }
}
