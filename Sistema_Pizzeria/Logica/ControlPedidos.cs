using Sistema_Pizzeria;
using Sistema_Pizzeria.BaseDatos;
using Sistema_Pizzeria.Datos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_Pizzeria.Logica
{
    class ControlPedidos
    {

        Conexion mConexion;
        public ControlPedidos()
        {
            mConexion = new Conexion();
            mConexion.conectar("MySQL ODBC 5.2w Driver", "localhost", "control", "root", "");
        }

        public void agregarPedido(Pedido mPedido)
        {
            String SQL = "insert into clientes values (null, '?1','?2','?3','?4')";
            SQL = SQL.Replace("?1", mPedido.Nombre);
            SQL = SQL.Replace("?2", mPedido.Direccion);
            SQL = SQL.Replace("?3", mPedido.Referencias);
            SQL = SQL.Replace("?4", mPedido.Telefono);
            mConexion.ejecutarActualizacion(SQL);
        }

        public DataTable consultarPedidos()
        {
            String SQL = "select * from Pedidos";
            DataTable ListaPedidos = mConexion.ejecutarConsulta(SQL);
            return ListaPedidos;
        }

        public DataTable historialPedidos(int ID)
        {
            String SQL = "select * from pizza where id_Pedido='?1'";
            SQL = SQL.Replace("?1", ID.ToString());
            DataTable ListaPedidos = mConexion.ejecutarConsulta(SQL);
            return ListaPedidos;
        }

        public DataTable consultarIDPedido()
        {
            String SQL = "select id_cliente from pedidos";
            DataTable ListaPedidos = mConexion.ejecutarConsulta(SQL);
            return ListaPedidos;
        }
        public void actualizarPedido(Pedido mPedido)
        {
            String SQL = "update clientes set nombre = '?1', direccion = '?2', referencias = '?3', telefono = '?4' where id_cliente = '?5'";
            SQL = SQL.Replace("?1", mPedido.Nombre);
            SQL = SQL.Replace("?2", mPedido.Direccion);
            SQL = SQL.Replace("?3", mPedido.Referencias);
            SQL = SQL.Replace("?4", mPedido.Telefono);
            SQL = SQL.Replace("?5", mPedido.IDpedido.ToString());

            mConexion.ejecutarActualizacion(SQL);
        }
        public void eliminarCliente(int ID)
        {
            String SQL = "delete from clientes where id_cliente='?1'";
            SQL = SQL.Replace("?1", ID.ToString());
            mConexion.ejecutarActualizacion(SQL);
        }
    }
}
