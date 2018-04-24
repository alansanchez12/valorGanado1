using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Diagnostics;


namespace Sistema_Pizzeria
{
    public partial class FrmClientes : Form
    {

        Validaciones validar = new Validaciones();
        public FrmClientes()
        {
            InitializeComponent();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            txtNombre.Text = "";
            txtDireccion.Text = "";
            txtReferencias.Text = "";
            txtTelefono.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if ((txtNombre.Text == "") || (txtDireccion.Text == "") || (txtTelefono.Text == ""))
            {
                MessageBox.Show("Los campos con asterisco son obligatorios");
            }
            else
            {

                try
                {
                    Cliente mCliente = new Cliente();
                    mCliente.Nombre = txtNombre.Text;
                    mCliente.Direccion = txtDireccion.Text;
                    mCliente.Referencias = txtReferencias.Text;
                    mCliente.Telefono = txtTelefono.Text;
                    mCliente.IDcliente = (int)dgvClientes.SelectedRows[0].Cells[0].Value;
                    ControlClientes mControl = new ControlClientes();

                    mControl.actualizarCliente(mCliente);
                    dgvClientes.DataSource = mControl.consultarClientes();
                    MessageBox.Show("Cliente Guardado!");
                }
                catch (Exception error)
                {
                    MessageBox.Show("Error al modificar: " + error);
                }
            }
        }

        private void btnAgregarCliente_Click(object sender, EventArgs e)
        {
            FrmAgregarCliente mAgregarCliente = new FrmAgregarCliente();
            this.Hide();
            mAgregarCliente.ShowDialog();
        }
    }
}
