using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_Pizzeria.Datos
{
    class Pedido
    {

        private int id_pedido;
        private int id_cliente;
        private String descripcion;
        private String cantidad;
        private int precio;
        


        public int IDPedido
        {
            get { return id_pedido; }
            set { id_pedido = value; }
        }
        public int IDcliente
        {
            get { return id_cliente; }
            set { id_cliente = value; }
        }

        public String Descripcion
        {
            get { return descripcion; }
            set { descripcion = value; }
        }

        public String Cantidad
        {
            get { return cantidad; }
            set { cantidad = value; }
        }

        public int Precio
        {
            get { return precio; }
            set { precio = value; }
        }

      
        }

    }


    