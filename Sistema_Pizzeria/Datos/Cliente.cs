using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_Pizzeria.Datos
{
    class Cliente
    {
        private int id_cliente;
        private String nombre;
        private String direccion;
        private String referencias;
        private String telefono;



        public String Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }

        public String Direccion
        {
            get { return direccion; }
            set { direccion = value; }
        }

        public String Referencias
        {
            get { return referencias; }
            set { referencias = value; }
        }

        public String Telefono
        {
            get { return telefono; }
            set { telefono = value; }
        }

        public int IDcliente
        {
            get { return id_cliente; }
            set { id_cliente = value; }
        }
    }
}


    