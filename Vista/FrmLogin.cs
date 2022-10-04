using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;

namespace Vista
{
    public partial class FrmLogin : Form
    {
        public static FrmLogin instancia;

        public FrmLogin()
        {
      
            InitializeComponent();
            
            
        }
        

        private void btn_entrar_Click(object sender, EventArgs e)
        {
            
            if(this.tb_usuario.Text!=null&&this.tb_usuario.Text!=""&& this.tb_pass.Text != null && this.tb_pass.Text != "")
            {
                if(Usuario.ValidarUsuario(this.tb_usuario.Text, this.tb_pass.Text))
                {
                    
                    FrmMenuPrincipal menu = new FrmMenuPrincipal(this.tb_usuario.Text);
                    instancia = this;
                    menu.Show();
                    this.Hide();
                }
                else
                {
                    lbl_login.Text = "Usuario o contraseña incorrectos";
                }
            }
            else
            {
                lbl_login.Text = "Error: Usuario o contraseña no validos";
            }
        }

        private void btn_backdoor_Click(object sender, EventArgs e)
        {
            FrmMenuPrincipal menu = new FrmMenuPrincipal("Santiago");
            instancia = this;
            menu.Show();
            this.Hide();
        }
    }
}
