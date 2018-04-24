using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Sistema_Pizzeria.BasedeDatos;
using Sistema_Pizzeria.Datos;

namespace Sistema_Pizzeria.Logica
{
    class ControlPedido
    {
        Conexion mConexion;
        public ControlPedido()
        {
            mConexion = new Conexion();
            mConexion.conectar("MySQL ODBC 5.2w Driver", "localhost", "pizzeria", "root", "admin");
        }

        public void agregarPedido(Pedido mPedido)
        {
            String SQL = "insert into pedido values (null, '?1','?2','?3','?4',')";
            SQL = SQL.Replace("?1", mPedido.IDcliente.ToString());
            SQL = SQL.Replace("?2", mPedido.Descripcion);
            SQL = SQL.Replace("?3", mPedido.Cantidad.ToString());
            SQL = SQL.Replace("?4", mPedido.Precio.ToString());

            mConexion.ejecutarActualizacion(SQL);
        }

        public DataTable Precio(int ID)
        {
            String SQL = "select Precio from pedido where id_pedido='?1'";
            SQL = SQL.Replace("?1", ID.ToString());
            DataTable Valor = mConexion.ejecutarConsulta(SQL);
            return Valor;
        }

        public DataTable consultarPedido()
        {
            String SQL = "select * from pedido";
            DataTable ListaPedido = mConexion.ejecutarConsulta(SQL);
            return ListaPedido;
        }
        public DataTable consultarIDPedido()
        {
            String SQL = "select id_pedido from pedido";
            DataTable ListaPedido = mConexion.ejecutarConsulta(SQL);
            return ListaPedido;
        }

        public void eliminarPedido(int ID)
        {
            String SQL = "delete from pedido where id_pedido='?1'";
            SQL = SQL.Replace("?1", ID.ToString());
            mConexion.ejecutarActualizacion(SQL);
        }

     
    }
}

    

