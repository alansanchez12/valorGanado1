using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Sistema_Pizzeria.Datos;
using Sistema_Pizzeria.Logica;

namespace Sistema_Pizzeria
{
    public partial class FrmAgregarCliente : Form
    {
        public FrmAgregarCliente()
        {
            InitializeComponent();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
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
                    ControlCliente mControl = new ControlCliente();
                    mControl.agregarCliente(mCliente);
                    MessageBox.Show("Cliente Guardado!");
                }
                catch (Exception error)
                {
                    MessageBox.Show("Error al actualizar");
                }
                this.Close();
            }
        }
    }
}


