using Entidades;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vista
{
    public partial class FrmMenuPrincipal : Form
    {
        public static FrmMenuPrincipal instancia;
        public List<Nave> listaNaves;
        public List<Vuelo> listaVuelos;
        public List<Destino> listaDestinos;
        public List<Pasajero> listaPasajeros;
        public List<Cliente> listaClientes;
        int flag=-1;
        double acumuladorFacturacionInternacional;
        double acumuladorFacturacionCabotaje;
        string nombreDestinoMasElegido = "";
        private FrmMenuPrincipal()
        {
            InitializeComponent();

        }

        public FrmMenuPrincipal(string nombreUsuario) : this()
        {
            this.lb_menuprincipal.Text = this.lb_menuprincipal.Text + " " + nombreUsuario + "\n" + DateTime.Now.ToShortDateString();
            listaNaves = Nave.InicializarNaves();
            listaDestinos = Destino.InicializarListaDestinos();
            t_tiemposDeVuelo.Start();
            listaVuelos = new List<Vuelo>();
            listaPasajeros = new List<Pasajero>();
            listaClientes = new List<Cliente>();
            instancia = this;

        }

        private void lb_menuprincipal_Click(object sender, EventArgs e)
        {

        }

        private void btn_agregarVuelo_Click(object sender, EventArgs e)
        {
            if(listaNaves.Where(Nave => Nave.asignadoAVuelo == false).Count() == 0) 
            {
                MessageBox.Show("No es posible agregar vuelos debido a falta de naves en la flota");
            }
            else
            {
                FrmAgregarVuelo menuAgregarVuelo = new FrmAgregarVuelo();
                menuAgregarVuelo.ShowDialog();
            }


        }

        private void btn_visualizarVuelos_Click(object sender, EventArgs e)
        {
            Visualizador.Visualizar(dgv_menuPrincipal, listaVuelos);
        }
        private void btn_VisualizarNaves_Click(object sender, EventArgs e)
        {
            Visualizador.Visualizar(dgv_menuPrincipal, listaNaves);
        }

        private void btn_AgregarPasajero_Click(object sender, EventArgs e)
        {

            if (listaVuelos.Where(Vuelo => Vuelo.estadoVueloAsignado == Vuelo.EstadoVuelo.Programado).Count() == 0)
            {
                MessageBox.Show("No es posible agregar pasajeros debido a falta de vuelos");
                
            }
            else
            {
                FrmAgregarPasajero menuAgregarPasajero = new FrmAgregarPasajero();
                menuAgregarPasajero.ShowDialog();
            }
        }

        private void btn_salir_Click(object sender, EventArgs e)
        {
            this.Close();
            FrmLogin.instancia.Close();
        }

        private void dgv_menuPrincipal_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string auxiliar = (string)dgv_menuPrincipal.CurrentRow.Cells[0].Value;
            if (listaVuelos.Exists(Vuelo => Vuelo.identificadorVuelo == auxiliar))
            {
                foreach (var Vuelo in listaVuelos)
                {
                    if (Vuelo.identificadorVuelo == auxiliar)
                    {
                        Visualizador.Visualizar(dgv_secundario, Vuelo.listaPasajeros);
                        break;
                    }
                }

            }
            else if (listaNaves.Exists(Nave => Nave.matricula == auxiliar))
            {
                foreach (var Nave in listaNaves)
                {
                    if (Nave.matricula == auxiliar)
                    {
                        Visualizador.Visualizar(dgv_secundario, Nave.vuelosRealizados);
                        break;
                    }
                }
            }
            else if (listaDestinos.Exists(Destino => Destino.nombreDestino == auxiliar))
            {
                foreach (var Destino in listaDestinos)
                {
                    if (Destino.nombreDestino == auxiliar)
                    {
                        Visualizador.Visualizar(dgv_secundario, Destino.vuelosRealizados);
                        break;
                    }
                }
            }else if (flag==0)
            {
                foreach(var Pasajero in listaPasajeros)
                {
                    if (Pasajero.dni == auxiliar)
                    {
                        Visualizador.Visualizar(dgv_secundario, Pasajero.equipajeEnBodega);
                        break;
                    }
                }
            }
            else if(flag == 1)
            {
                foreach(var Cliente in listaClientes)
                {
                    if (Cliente.dni == auxiliar)
                    {
                        Visualizador.Visualizar(dgv_secundario, Cliente.vuelosRealizados);
                        break;
                    }
                }

            }
        }

        private void t_salidaVuelo_Tick(object sender, EventArgs e)
        {
            Vuelo.actualizarVuelo(listaVuelos, listaPasajeros);
        }

        private void btn_visualizarDestinos_Click(object sender, EventArgs e)
        {

            Visualizador.Visualizar(dgv_menuPrincipal, listaDestinos);
            acumuladorFacturacionCabotaje = Destino.acumularRecaudacionDestinos(listaDestinos, TipoServicio.cabotaje);
            acumuladorFacturacionInternacional = Destino.acumularRecaudacionDestinos(listaDestinos, TipoServicio.internacional);
            nombreDestinoMasElegido = Destino.buscarDestinoMasElegido(listaDestinos);

            lbl_estadisticas.Text = "Destino mas elegido: " + nombreDestinoMasElegido + "\n" + "Recaudacion cabotaje: " + acumuladorFacturacionCabotaje + "\n" + "Recaudacion Internacional: " + acumuladorFacturacionInternacional;

        }

        private void btn_visualizarPasajeros_Click(object sender, EventArgs e)
        {
            Visualizador.Visualizar(dgv_menuPrincipal, listaPasajeros);
            flag = 0;
        }

        private void btn_visualizarClientes_Click(object sender, EventArgs e)
        {
            Visualizador.Visualizar(dgv_menuPrincipal, listaClientes);
            flag = 1;
        }

        private void btn_ayuda_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Boton Agregar Vuelo: Programar un nuevo vuelo luego de asignar destino y nave\n" +
                "Boton Agregar Pasajero: Agrega un pasajero nuevo con los datos ingresados y los asigna a un vuelo\n" +
                "Ver Pasajeros: Permite ver los pasajeros actuales que se encuentran asignados a un vuelo\n" +
                "Ver Vuelos: Permite ver los vuelos programados, en curso y finalizados\n"+
                "Ver Clientes: Nos permite ver clientes y su historial de vuelos individual\n" +
                "Ver Naves:Nos permite ver los detalles de las naves en la floata y su historial de vuelo\n" +
                "Ver Destinos:Nos permite ver estadisticas relacionadas con cada destino");
        }

        private void lbl_estadisticas_Click(object sender, EventArgs e)
        {

        }

        private void btn_agregarNonGrata_Click(object sender, EventArgs e)
        {
            Frm_agregarNonGrata frm_AgregarNonGrata = new Frm_agregarNonGrata();
            frm_AgregarNonGrata.Show();
        }
    }
}
