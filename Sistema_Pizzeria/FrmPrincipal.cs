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
    public partial class FrmPrincipal : Form
    {
        public FrmPrincipal()
        {
            InitializeComponent();
        }

        private void btnCerrarSesion_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnClientes_Click(object sender, EventArgs e)
        {
            FrmCliente mFrmCliente = new FrmCliente();
            mFrmCliente.ShowDialog();
        }

        private void btnPedidos_Click(object sender, EventArgs e)
        {
            FrmPedido mFrmAgregar = new FrmPedido();
            mFrmAgregar.ShowDialog();
        }
    }
}
