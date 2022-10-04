using Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;


namespace Vista
{
    public partial class FrmAgregarVuelo : Form
    {
        public FrmAgregarVuelo()
        {
            InitializeComponent();


            
            var bindingSourceNaves = new BindingSource();
            bindingSourceNaves.DataSource = FrmMenuPrincipal.instancia.listaNaves.Where(item => item.asignadoAVuelo != true).ToList();
            var bindingSourceDestinos = new BindingSource();
            bindingSourceDestinos.DataSource = FrmMenuPrincipal.instancia.listaDestinos;
            cb_naves.DataSource = bindingSourceNaves.DataSource;
            cb_naves.DisplayMember = "matricula";
            cb_destinos.DataSource = bindingSourceDestinos;
            cb_destinos.ValueMember = "instancia";
            cb_destinos.DisplayMember = "nombreDestino";
            

        }

        private void btn_confirmarAgregarVuelo_Click(object sender, EventArgs e)
        {
            
            Nave naveSeleccionada = (Nave)cb_naves.SelectedItem;
            Destino destinoSeleccionado = (Destino)cb_destinos.SelectedItem;
            
            FrmMenuPrincipal.instancia.listaVuelos.Add(new Vuelo(naveSeleccionada, destinoSeleccionado,dtp_AgregarVuelo.Value.Date));
            destinoSeleccionado.acumuladorVecesElegido++;
            naveSeleccionada.asignadoAVuelo = true;
            this.Close();
        }

        private void btn_cancelarAgregarVuelo_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
