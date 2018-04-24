using Sistema_Pizzeria.Datos;
using Sistema_Pizzeria.BasedeDatos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_Pizzeria.Logica
{
    class ControlCliente
    {

        Conexion mConexion;
        
        public ControlCliente()
        {
            mConexion = new Conexion();
            mConexion.conectar("MySQL ODBC 5.2w Driver", "localhost", "pizzeria", "root", "admin");
        }

        public void agregarCliente(Cliente mCliente)
        {
            String SQL = "insert into Cliente values (null, '?1','?2','?3','?4')";
            SQL = SQL.Replace("?1", mCliente.Nombre);
            SQL = SQL.Replace("?2", mCliente.Direccion);
            SQL = SQL.Replace("?3", mCliente.Referencias);
            SQL = SQL.Replace("?4", mCliente.Telefono);
            mConexion.ejecutarActualizacion(SQL);
        }

        public DataTable consultarClientes()
        {
            String SQL = "select * from Cliente";
            DataTable ListaClientes = mConexion.ejecutarConsulta(SQL);
            return ListaClientes;
        }

        public DataTable historialCliente(int ID)
        {
            String SQL = "select * from Pedido where id_cliente='?1'";
            SQL = SQL.Replace("?1", ID.ToString());
            DataTable ListaClientes = mConexion.ejecutarConsulta(SQL);
            return ListaClientes;
        }

        public DataTable consultarIDclientes()
        {
            String SQL = "select id_cliente from Cliente";
            DataTable ListaClientes = mConexion.ejecutarConsulta(SQL);
            return ListaClientes;
        }
        public void actualizarCliente(Cliente mCliente)
        {
            String SQL = "update Cliente set nombre = '?1', direccion = '?2', referencias = '?3', telefono = '?4' where id_cliente = '?5'";
            SQL = SQL.Replace("?1", mCliente.Nombre);
            SQL = SQL.Replace("?2", mCliente.Direccion);
            SQL = SQL.Replace("?3", mCliente.Referencias);
            SQL = SQL.Replace("?4", mCliente.Telefono);
            SQL = SQL.Replace("?5", mCliente.IDcliente.ToString());

            mConexion.ejecutarActualizacion(SQL);
        }
        public void eliminarCliente(int ID)
        {
            String SQL = "delete from Cliente where id_cliente='?1'";
            SQL = SQL.Replace("?1", ID.ToString());
            mConexion.ejecutarActualizacion(SQL);
        }

    }
}

  
