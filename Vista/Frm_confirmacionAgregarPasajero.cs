using Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vista
{
    public partial class Frm_confirmacionAgregarPasajero : Form
    {

      
        int maximoPesoEquipaje;
        int edad;
        string nombre;
        string apellido;
        string dni;
        Vuelo vuelo;
        Clase clase;

        public Frm_confirmacionAgregarPasajero()
        {
            InitializeComponent();


        }

        public Frm_confirmacionAgregarPasajero(DataGridView dgvVuelo, string nombreIngresado, string apellidoIngresado, string dniIngresado, DateTime fechaNacimiento, bool esPremium) : this()
        {
            
            edad= DateTime.Today.Year - fechaNacimiento.Year;
            clase = Clase.Economica;
            nombre = nombreIngresado;
            apellido = apellidoIngresado;
            dni = dniIngresado;
            string auxiliar = (string)dgvVuelo.CurrentRow.Cells[0].Value;
            maximoPesoEquipaje = 25;
            nud_pesoEquipajeDos.Hide();
            foreach (var Vuelo in FrmMenuPrincipal.instancia.listaVuelos)
            {
                if (Vuelo.identificadorVuelo == auxiliar)
                {
                    vuelo=Vuelo.instancia;
                    break;
                }
            }

            if (esPremium)
            {
                maximoPesoEquipaje = 21;
                nud_pesoEquipajeDos.Maximum = maximoPesoEquipaje;
                nud_pesoEquipajeDos.Show();
                clase = Clase.Premium;
            }
            nud_pesoEquipajeUno.Maximum = maximoPesoEquipaje;
            nud_pesoEquipajeDos.Maximum = maximoPesoEquipaje;
            Visualizador.MostrarMonto(lbl_costoDeVuelo, esPremium, vuelo.costoVueloBase);
        }

        private void btn_confirmarPasajeroEnVuelo_Click(object sender, EventArgs e)
        {
            List<Equipaje> equipajeAsignado= new List<Equipaje>();


            if(nud_pesoEquipajeUno.Value != 0)
            {
                equipajeAsignado.Add(new Equipaje((double)nud_pesoEquipajeUno.Value));
            }
            if(nud_pesoEquipajeDos.Value!=0)
            {
                equipajeAsignado.Add(new Equipaje((double)nud_pesoEquipajeDos.Value));
            }
            if (Vuelo.confirmarAsienstosDisponibles(vuelo,clase))
            {
                Pasajero nuevoPasajero = new Pasajero(clase, dni, nombre, apellido, edad, equipajeAsignado,vuelo.instancia);
                vuelo.listaPasajeros.Add(nuevoPasajero);
                FrmMenuPrincipal.instancia.listaPasajeros.Add(nuevoPasajero);
                Cliente.AsignarPasajeroAListaClientes(FrmMenuPrincipal.instancia.listaClientes, nuevoPasajero);
                Vuelo.actualizarAsientosDisponibles(vuelo, clase);

                this.Close();
            }
            else
            {
                MessageBox.Show("No hay asientos disponibles en este vuelo para la clase seleccionada");
            }

            

        }

        private void btn_cancelarPasajeroEnVuelo_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
