using GestionDePedido.DAL;
using GestionDePedido.Modelos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionDePedido.BSS
{
    public class PedidoBss
    {
        PedidoDal dal = new PedidoDal();
        public DataTable ListarPedidoBss()
        {
            return dal.ListarPedidoDal();
        }
        public void InsertarPedidoBss(Pedido pedido)
        {
            dal.InsertarPedidoDal(pedido);
        }
        public Pedido ObtenerIdBss(int id)
        {
            return dal.ObtenerPedidoId(id);
        }
        public void EditarPedidoBss(Pedido p)
        {
            dal.EditarPedidoDal(p);
        }
        public void EliminarPedidoBss(int id)
        {
            dal.EliminarPedidoDal(id);

        }
        public DataTable PedidoDatosBss()
        {
            return dal.PedidoDatosDal();
        }
        public DataTable PedidoDatosMostrarBss()
        {
            return dal.PedidoDatosMostrarDal();
        }   
    }
}
