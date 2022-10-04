using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public abstract class Persona
    {
        public string dni;
        public string nombre;
        public string apellido;
        public int edad;

        protected Persona(string dni, string nombre, string apellido, int edad)
        {
            this.dni = dni;
            this.nombre = nombre;
            this.apellido = apellido;
            this.edad = edad;
        }   
    }

    public class Pasajero:Persona
    {
        
        public Clase clase { get; set; }
        public List<Equipaje> equipajeEnBodega;
        public Vuelo vuelo;
        public Pasajero( Clase clase, string dni, string nombre, string apellido, int edad, List<Equipaje> equipajeAsignado, Vuelo vueloAsignado) : base(dni, nombre, apellido, edad)
        {
            this.clase = clase;
            equipajeEnBodega = equipajeAsignado;
            this.vuelo = vueloAsignado;
        }
    }

    public class Cliente : Persona
    {
        public List<Vuelo> vuelosRealizados;
        public int contadorVuelosRealizados;
        public Cliente(string dni, string nombre, string apellido, int edad) : base(dni, nombre, apellido, edad)
        {
            vuelosRealizados = new List<Vuelo>();
            contadorVuelosRealizados = 1;
        }

        public static void AsignarPasajeroAListaClientes(List<Cliente> listaClientes, Pasajero pasajeroIngresado)
        {
            if (listaClientes.Exists(Cliente => Cliente.dni == pasajeroIngresado.dni))
            {
                foreach (var Cliente in listaClientes)
                {
                    if (Cliente.dni == pasajeroIngresado.dni)
                    {
                        Cliente.contadorVuelosRealizados++;
                        Cliente.vuelosRealizados.Add(pasajeroIngresado.vuelo);
                    }
                }
            }
            else
            {
                listaClientes.Add(new Cliente(pasajeroIngresado.dni, pasajeroIngresado.nombre, pasajeroIngresado.apellido, pasajeroIngresado.edad));
            }

            
        }

    }


     
    public enum Clase
    {
        Premium,
        Economica
    }

}
