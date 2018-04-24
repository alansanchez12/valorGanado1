using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_Pizzeria.Datos
{
    class Venta
    {
        private int id_Pizza;
        private int id_Pedido;
        private string Tipopizza;
        private DateTime TiempoEspera;
        private String tipo_articulo;
        private String nombre_articulo;
        private String descripcion;
        private String condiciones_articulo;
        private float costo;
        private int porcentaje_pagar;
        private String estado_articulo;
        public string Avaluo { get; set; }


        public int IDPizza
        {
            get { return id_Pizza; }
            set { id_Pizza = value; }
        }
        public int IDcliente
        {
            get { return id_Pedido; }
            set { id_Pedido = value; }
        }
        public string Tipopiza
        {
            get { return Tipopizza; }
            set { Tipopizza = value; }
        }

        public DateTime Horantrega
        {
            get { return Horantrega; }
            set { Horantrega = value; }
        }

        public String TipoArticulo
        {
            get { return tipo_articulo; }
            set { tipo_articulo = value; }
        }

        public String NombreArticulo
        {
            get { return nombre_articulo; }
            set { nombre_articulo = value; }
        }

        public String Descripcion
        {
            get { return descripcion; }
            set { descripcion = value; }
        }

        public String CondicionesArticulo
        {
            get { return condiciones_articulo; }
            set { condiciones_articulo = value; }
        }

        public float Costo
        {
            get { return costo; }
            set { costo = value; }
        }


        public int PorcentajePagar
        {
            get { return porcentaje_pagar; }
            set { porcentaje_pagar = value; }
        }

        public String EstadoArticulo
        {
            get { return estado_articulo; }
            set { estado_articulo = value; }
        }
    }
}
