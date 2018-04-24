using Sistema_Pizzeria.Datos;
using Sistema_Pizzeria.Logica;
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
    public partial class FrmAgregarPedido : Form
    {
        public FrmAgregarPedido()
        {
            InitializeComponent();
        }

        private void cmbCliente_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cmbTipo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            
           
            

            if ( (cmbDireccion.Text == "")  || (cmbCliente.Text == ""))
            {
                MessageBox.Show("No se admiten campos vacíos");
            }
          
          
            else
            {

                try
                {
                    Pedido mPedido = new Pedido();
                    mPedido.IDcliente = int.Parse(cmbCliente.SelectedValue.ToString());
            
                mPedido.Descripcion = cmbDireccion.Text;
                    mPedido.Descripcion = cmbCantidad.Text;
                    mPedido.Precio = int.Parse(txtPrecio.Text.ToString());
                   
                 
                  
          

                    ControlPedido mControl = new ControlPedido();
                    mControl.agregarPedido(mPedido);
                    MessageBox.Show("Pedids Guardado!");
                }
                catch (Exception error)
                {
                    MessageBox.Show("Error al actualizar: " + error);
                }
                this.Close();
            }
        }
    }
    }

