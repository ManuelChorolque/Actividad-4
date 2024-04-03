using GestionDePedido.BSS;
using GestionDePedido.Modelos;
using GestionDePedido.VISTA.ClienteVista;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestionDePedido.VISTA.PedidoVista
{
    public partial class PedidoMostrarTotalVista : Form
    {
        public PedidoMostrarTotalVista()
        {
            InitializeComponent();
        }
        PedidoBss bss = new PedidoBss();

        public static int IdClienteSeleccionada = 0;
        private void button3_Click(object sender, EventArgs e)
        {
            ClienteBss bss = new ClienteBss();
            ClienteListarVista fr = new ClienteListarVista();
            if (fr.ShowDialog() == DialogResult.OK)
            {
                Cliente cliente = bss.ObtenerIdBss(IdClienteSeleccionada);
                textBox1.Text = cliente.Nombre + " " + cliente.Apellido;
            }
        }

    }
}
