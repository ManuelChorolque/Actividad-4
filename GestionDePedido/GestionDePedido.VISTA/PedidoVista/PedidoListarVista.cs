using GestionDePedido.BSS;
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
    public partial class PedidoListarVista : Form
    {
        public PedidoListarVista()
        {
            InitializeComponent();
        }
        PedidoBss bss = new PedidoBss();
        private void PedidoListarVista_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = bss.PedidoDatosBss();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            PedidoInsertarVista fr = new PedidoInsertarVista();
            if (fr.ShowDialog() == DialogResult.OK)
            {
                dataGridView1.DataSource = bss.PedidoDatosBss();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int IdPedidoSelecionado = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
            PedidoEditarVista fr = new PedidoEditarVista(IdPedidoSelecionado);
            if (fr.ShowDialog() == DialogResult.OK)
            {
                dataGridView1.DataSource = bss.PedidoDatosBss();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int IdPedidoSelecionado = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
            DialogResult result = MessageBox.Show("Esta seguro de elimar este pedido", "Eliminando", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                bss.EliminarPedidoBss(IdPedidoSelecionado);
                dataGridView1.DataSource = bss.PedidoDatosBss();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            PedidoMostrarTotalVista fr = new PedidoMostrarTotalVista();
            fr.Show();
        }
    }
}
