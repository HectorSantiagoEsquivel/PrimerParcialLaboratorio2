using Entidades;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Vista
{
    public class Visualizador
    {
        static public void Visualizar(DataGridView dgv_ingresado, List<Nave> listaNaves)
        {
            
            dgv_ingresado.DataSource = null;
            dgv_ingresado.Rows.Clear();
            DataTable tabla=new DataTable();
            tabla.Columns.Add("Matricula", typeof(string));
            tabla.Columns.Add("Cantidad Asientos", typeof(int));
            tabla.Columns.Add("Asignado a Vuelo", typeof(string));
            tabla.Columns.Add("Horas de Vuelo Realizadas", typeof(double));
           
            foreach (var Nave in listaNaves)
            {
                tabla.Rows.Add(Nave.matricula, Nave.cantAsientos, Nave.asignadoAVuelo.ToString(), Nave.horasDeVueloTotal);

            }

            dgv_ingresado.DataSource = tabla;
        }
        static public void Visualizar(DataGridView dgv_ingresado, List<Vuelo> listaVuelos)
        {
            
            dgv_ingresado.DataSource = null;
            dgv_ingresado.Rows.Clear();
            DataTable tabla = new DataTable();
            tabla.Columns.Add("Vuelo", typeof(string));
            tabla.Columns.Add("Destino", typeof(string));
            tabla.Columns.Add("Costo Base", typeof(double));
            tabla.Columns.Add("Asientos Libres Economica", typeof(int));
            tabla.Columns.Add("Asientos Libres Premium", typeof(int));
            tabla.Columns.Add("Fecha de Salida", typeof(string));
            tabla.Columns.Add("Fecha de Llegada", typeof(string));
            tabla.Columns.Add("Estado", typeof(string));

            foreach (var Vuelo in listaVuelos)
            {
                tabla.Rows.Add(Vuelo.identificadorVuelo,Vuelo.destino.nombreDestino, Vuelo.costoVueloBase, Vuelo.asientosLibresEco, Vuelo.asientosLibresPremium,Vuelo.fechaDeSalida.ToString(),Vuelo.fechaDeLlegada.ToString(), Vuelo.estadoVueloAsignado.ToString());

            }

            dgv_ingresado.DataSource = tabla;
        }

        static public void Visualizar(DataGridView dgv_ingresado, List<Pasajero> listaPasajeros)
        {
            dgv_ingresado.DataSource = null;
            dgv_ingresado.Rows.Clear();
            DataTable tabla = new DataTable();
            tabla.Columns.Add("Documento", typeof(string));
            tabla.Columns.Add("Nombre", typeof(string));
            tabla.Columns.Add("Apellido", typeof(string));
            tabla.Columns.Add("Edad", typeof(int));
            tabla.Columns.Add("Vuelo", typeof(string));
            tabla.Columns.Add("Clase", typeof(string));
            

            foreach (var Pasajero in listaPasajeros)
            {
                tabla.Rows.Add(Pasajero.dni,Pasajero.nombre,Pasajero.apellido,Pasajero.edad,Pasajero.vuelo.identificadorVuelo, Pasajero.clase.ToString());

            }
            dgv_ingresado.DataSource = tabla;

        }
        static public void Visualizar(DataGridView dgv_ingresado, List<Cliente> listaClientes)
        {
            dgv_ingresado.DataSource = null;
            dgv_ingresado.Rows.Clear();
            DataTable tabla = new DataTable();
            tabla.Columns.Add("Documento", typeof(string));
            tabla.Columns.Add("Nombre", typeof(string));
            tabla.Columns.Add("Apellido", typeof(string));
            tabla.Columns.Add("Edad", typeof(int));
            tabla.Columns.Add("Numero de Vuelos", typeof(int));



            foreach (var Cliente in listaClientes)
            {
                tabla.Rows.Add(Cliente.dni, Cliente.nombre, Cliente.apellido, Cliente.edad, Cliente.contadorVuelosRealizados);

            }
            dgv_ingresado.DataSource = tabla;

        }

        static public void Visualizar(DataGridView dgv_ingresado, List<Destino> listaDestinos)
        {

            dgv_ingresado.DataSource = null;
            dgv_ingresado.Rows.Clear();
            DataTable tabla = new DataTable();
            tabla.Columns.Add("Destino", typeof(string));
            tabla.Columns.Add("Facturacion Total", typeof(double));
            tabla.Columns.Add("Veces Elegido", typeof(int));
            tabla.Columns.Add("Tipo Servicio", typeof(string));


            foreach (var Destino in listaDestinos)
            {
                tabla.Rows.Add(Destino.nombreDestino, Destino.acumuladorFacturacion, Destino.acumuladorVecesElegido, Destino.tipoServicio.ToString());

            }

            dgv_ingresado.DataSource = tabla;
        }
        static public void Visualizar(DataGridView dgv_ingresado, List<Equipaje> listaEquipaje)
        {

            dgv_ingresado.DataSource = null;
            dgv_ingresado.Rows.Clear();
            DataTable tabla = new DataTable();
            tabla.Columns.Add("Peso Equipaje", typeof(double));


            foreach (var Equipaje in listaEquipaje)
            {
                tabla.Rows.Add(Equipaje.peso);

            }

            dgv_ingresado.DataSource = tabla;
        }

        static public void MostrarMonto(Label lbl_ingresada, bool esPremium, double costoBase)
        {
            double costoBruto;
            double costoIVA;
            if (costoBase != null && esPremium != null)
            {
                if (esPremium)
                {
                    costoBruto = costoBase + (costoBase * 15) / 100;
                    
                    
                }
                else
                {
                    costoBruto = costoBase;
                }
                costoIVA = costoBruto + (costoBruto * 21) / 100;
                lbl_ingresada.Text = "El Costo Bruto es: " + costoBruto + "USD\n"+"El costo con IVA es: "+ costoIVA+"USD";
            }
        }


    }
}
