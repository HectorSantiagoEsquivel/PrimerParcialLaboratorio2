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
    public partial class Frm_agregarNonGrata : Form
    {
        public Frm_agregarNonGrata()
        {
            InitializeComponent();
            Visualizador.Visualizar(dgv_agregarNonGrata, FrmMenuPrincipal.instancia.listaClientes);
        }

        private void btn_confirmarAgregarNonGrata_Click(object sender, EventArgs e)
        {
            string auxiliar = (string)dgv_agregarNonGrata.CurrentRow.Cells[0].Value;
            foreach (var Cliente in FrmMenuPrincipal.instancia.listaClientes)
            {
                if (Cliente.dni==auxiliar)
                {
                    Cliente.AsignarCategoria(Cliente,Categoria.NonGrata);
                    break;
                }
            }
        }

        private void btn_cancelarAgregarNonGrata_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
