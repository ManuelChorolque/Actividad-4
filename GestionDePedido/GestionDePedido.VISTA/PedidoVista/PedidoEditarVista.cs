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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace GestionDePedido.VISTA.PedidoVista
{
    public partial class PedidoEditarVista : Form
    {
        int idx = 0;
        Pedido p = new Pedido();
        PedidoBss bss = new PedidoBss();
        public PedidoEditarVista(int id)
        {
            idx = id;
            InitializeComponent();
        }

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
        private void PedidoEditarVista_Load(object sender, EventArgs e)
        {
            p = bss.ObtenerIdBss(idx);
            textBox1.Text = p.IdCliente.ToString();
            dateTimePicker1.Value = p.Fecha;
            textBox2.Text = p.Total.ToString();
            textBox3.Text = p.Estado;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            p.IdCliente = IdClienteSeleccionada;
            p.Fecha = dateTimePicker1.Value;
            p.Total = Convert.ToDecimal(textBox2.Text);
            p.Estado = textBox3.Text;

            bss.EditarPedidoBss(p);
            MessageBox.Show("Datos actualizados");
        }
        
    }
}
