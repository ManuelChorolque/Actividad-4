using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GestionDePedido.DAL;
using GestionDePedido.Modelos;

namespace GestionDePedido.DAL
{
    public class ClienteDal
    {
        public DataTable ListarClienteDal()
        {
            string consulta = "select * from cliente";
            DataTable Lista = conexion.EjecutarDataTabla(consulta, "tabla");
            return Lista;
        }
        public void InsertarClienteDal(Cliente cliente)
        {
            string consulta = "insert into cliente values('" + cliente.Nombre + "'," +
                                                        "'" + cliente.Apellido + "'," +
                                                        "'" + cliente.Correo + "'," +
                                                        "'" + cliente.Telefono + "'," +
                                                        "'" + cliente.Direccion + "')";
            conexion.Ejecutar(consulta);
        }
        public Cliente ObtenerClienteId(int id)
        {
            string consulta = "select * from cliente where idcliente=" + id;
            DataTable tabla = conexion.EjecutarDataTabla(consulta, "asdas");
            Cliente c = new Cliente();

            if (tabla.Rows.Count > 0)
            {
                c.IdCliente = Convert.ToInt32(tabla.Rows[0]["idcliente"]);         
                c.Nombre = tabla.Rows[0]["nombre"].ToString();
                c.Apellido = tabla.Rows[0]["apellido"].ToString();
                c.Correo = tabla.Rows[0]["correo"].ToString();
                c.Telefono = tabla.Rows[0]["telefono"].ToString();
                c.Direccion = tabla.Rows[0]["direccion"].ToString();
            }

            return c;

        }
        public void EditarClienteDal(Cliente c)
        {
            string consulta = "update cliente set nombre='" + c.Nombre + "'," +
                                                  "apellido='" + c.Apellido + "'," +
                                                  "correo='" + c.Correo + "'," +
                                                  "telefono='" + c.Telefono + "'," +
                                                  "direccion='" + c.Direccion + "'" +
                                              "where idcliente=" + c.IdCliente;
            conexion.Ejecutar(consulta);
        }
        public void EliminarClienteDal(int id)
        {
            string consulta = "delete from cliente where idcliente=" + id;
            conexion.Ejecutar(consulta);
        }
    }
}
