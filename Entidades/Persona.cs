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

        public Clase Clase
        {
            get => default;
            set
            {
            }
        }

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
        public Categoria categoria { get; set; }

        public Categoria Categoria
        {
            get => default;
            set
            {
            }
        }

        public Cliente(Categoria categoria,string dni, string nombre, string apellido, int edad) : base(dni, nombre, apellido, edad)
        {
            this.categoria = categoria;
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
                        if (Cliente.contadorVuelosRealizados>5)
                        {
                            Cliente.categoria = Categoria.Regular;
                        }
                    }
                }
            }
            else
            {
                listaClientes.Add(new Cliente(Categoria.Ocasional,pasajeroIngresado.dni, pasajeroIngresado.nombre, pasajeroIngresado.apellido, pasajeroIngresado.edad));
            }         
        }

        public static void AsignarCategoria(Cliente clienteIngresado, Categoria categoria)
        {
            clienteIngresado.categoria = categoria;        
        }

        public static bool ValidarCategoriaCliente(string dni,List<Cliente> listaIngresada)
        {
            
            foreach (var Cliente in listaIngresada)
            {
                if (Cliente.dni == dni)
                {
                    if (Cliente.categoria == Categoria.NonGrata || Cliente.categoria == Categoria.Volando)
                    {
                        return false;
                    }
                    break;
                }
            }
            return true;

        }

    }


     
    public enum Clase
    {
        Premium,
        Economica
    }

    public enum Categoria
    {
        Ocasional,
        Regular,
        Volando,
        NonGrata
    }

}
