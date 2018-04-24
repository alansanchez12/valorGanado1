using System;
using Sistema_Pizzeria.Datos;
using Sistema_Pizzeria.BasedeDatos;
using Sistema_Pizzeria.Logica;
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
    public partial class FrmCliente : Form
    {
        public FrmCliente()
        {
            InitializeComponent();
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                Cliente mCliente = new Cliente();
                int ID = (int)dgvClientes.SelectedRows[0].Cells[0].Value;

                ControlCliente mControl = new ControlCliente();
                mControl.eliminarCliente(ID);
                MessageBox.Show("Cliente eliminado");
            }
            catch (Exception error)
            {
                MessageBox.Show("El cliente tiene Pedidos registrados, no es posible eliminarlo.");
            }
        }

        private void dgvClientes_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                txtNombre.Text = dgvClientes.CurrentRow.Cells["nombre"].Value.ToString();
                txtDireccion.Text = dgvClientes.CurrentRow.Cells["direccion"].Value.ToString();
                txtReferencias.Text = dgvClientes.CurrentRow.Cells["referencias"].Value.ToString();
                txtTelefono.Text = dgvClientes.CurrentRow.Cells["telefono"].Value.ToString();
            }
            catch
            {

            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void btnAgregarCliente_Click(object sender, EventArgs e)
        {

        }
    }
    }

