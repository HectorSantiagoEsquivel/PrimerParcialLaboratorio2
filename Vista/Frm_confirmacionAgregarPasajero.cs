using Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vista
{
    public partial class Frm_confirmacionAgregarPasajero : Form
    {
        DataGridView dgvVuelo;
        string nombre;
        string apellido;
        string dni;
        DateTime fechaNacimiento;
        bool esPremium;
        int maximoPesoEquipaje;
        int edad;
        Vuelo vuelo;
        Clase clase;

        public Frm_confirmacionAgregarPasajero()
        {
            InitializeComponent();


        }

        public Frm_confirmacionAgregarPasajero(DataGridView dgvSeleccionado,string nombreIngresado, string apellidoIngresado, string dniIngresado,DateTime fechaDeNacimientoIngresada, bool esPremiumIngresado) : this()
        {
           
            edad= DateTime.Today.Year - fechaNacimiento.Year;
            clase = Clase.Economica;
            dgvVuelo = dgvSeleccionado;
            string auxiliar = (string)dgvVuelo.CurrentRow.Cells[0].Value;
            nombre = nombreIngresado;
            apellido = apellidoIngresado;
            dni = dniIngresado;
            fechaNacimiento = fechaDeNacimientoIngresada;
            esPremium = esPremiumIngresado;
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

            if (Validador.ValidarString(nombre) && Validador.ValidarString(apellido) && Validador.ValidarString(dni))
            {
                if(nud_pesoEquipajeUno.Value != 0)
                {
                    equipajeAsignado.Add(new Equipaje((double)nud_pesoEquipajeUno.Value));
                }
                if(nud_pesoEquipajeDos.Value!=0)
                {
                    equipajeAsignado.Add(new Equipaje((double)nud_pesoEquipajeDos.Value));
                }
                if ((vuelo.asientosLibresPremium > 0 && clase == Clase.Premium) || (vuelo.asientosLibresEco > 0 && clase == Clase.Economica))
                {
                    Pasajero nuevoPasajero = new Pasajero(clase, dni, nombre, apellido, edad, equipajeAsignado,vuelo.instancia);
                    vuelo.listaPasajeros.Add(nuevoPasajero);
                    FrmMenuPrincipal.instancia.listaPasajeros.Add(nuevoPasajero);
                    Cliente.AsignarPasajeroAListaClientes(FrmMenuPrincipal.instancia.listaClientes, nuevoPasajero);
                    if (clase == Clase.Premium)
                    {
                        vuelo.asientosLibresPremium = vuelo.asientosLibresPremium - 1;
                    }
                    else
                    {
                        vuelo.asientosLibresEco = vuelo.asientosLibresEco - 1;
                    }
                    this.Close();
                }
                else
                {
                    MessageBox.Show("No hay asientos disponibles en este vuelo para la clase seleccionada");
                }



            }
            else
            {
                MessageBox.Show("Error: Datos No validos");
            }
        }

        private void btn_cancelarPasajeroEnVuelo_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
