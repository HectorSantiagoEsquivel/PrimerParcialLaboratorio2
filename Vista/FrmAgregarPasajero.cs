using Entidades;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.AxHost;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Vista
{
    public partial class FrmAgregarPasajero : Form
    {
        public FrmAgregarPasajero()
        {
            
            InitializeComponent();
            Visualizador.Visualizar(dgv_agregarPasajero, FrmMenuPrincipal.instancia.listaVuelos.Where(Vuelo => Vuelo.estadoVueloAsignado == Vuelo.EstadoVuelo.Programado).ToList());
            

        }

        private void btn_agregarPasajeroConfirmar_Click(object sender, EventArgs e)
        {

            if (Validador.ValidarString(tb_nombre.Text) && Validador.ValidarString(tb_apellido.Text) && Validador.ValidarDNI(tb_DNI.Text))
            {

                Frm_confirmacionAgregarPasajero menuConfirmar = new Frm_confirmacionAgregarPasajero(dgv_agregarPasajero, tb_nombre.Text, tb_apellido.Text, tb_DNI.Text, dtp_fechaDeNacimiento.Value, chb_esPremium.Checked);
                menuConfirmar.Show();
            }
            else
            {
                MessageBox.Show("Error: Datos ingresados no validos");
            }
                 


        }

        private void btn_agregarPasajeroCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void chb_esPremium_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
