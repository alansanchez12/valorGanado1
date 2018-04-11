using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sistema_Pizzeria
{
    public partial class FrmLogin : Form
    {
        
        
            Validaciones validar = new Validaciones();


        public FrmLogin()
        {
            InitializeComponent();
            txtContra.Text = "";
            txtContra.PasswordChar = '*';
        }
       

        private void btnIniciarSesion_Click(object sender, EventArgs e)
        {
            if ((txtUsuario.Text == "") && (txtContra.Text == ""))
            {
                MessageBox.Show("Error");
            }

            else if ((txtUsuario.Text == "admin") && (txtContra.Text == "4477"))
            {
                FrmPrincipal mFrmPrincipal = new FrmPrincipal();
                this.Hide();
                mFrmPrincipal.ShowDialog();

                this.Close();
            }
            else
            {
                MessageBox.Show("Error");
            }
        }

        private void txtUsuario_KeyPress(object sender, KeyPressEventArgs e)
        {
            validar.Letras(e);
        }

        private void txtContra_KeyPress(object sender, KeyPressEventArgs e)
        {
            validar.Numeros(e);
        }

        private void FrmLogin_Load(object sender, EventArgs e)
        {

        }
    }
}
