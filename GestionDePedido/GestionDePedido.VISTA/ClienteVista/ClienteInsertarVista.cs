using GestionDePedido.BSS;
using GestionDePedido.Modelos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestionDePedido.VISTA.ClienteVista
{
    public partial class ClienteInsertarVista : Form
    {
        public ClienteInsertarVista()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ClienteBss bss = new ClienteBss();
            Cliente c = new Cliente();
            c.Nombre = textBox1.Text;
            c.Apellido = textBox2.Text;
            c.Correo = textBox3.Text;
            c.Telefono = textBox4.Text;
            c.Direccion = textBox5.Text;

            bss.InsertarClienteBss(c);
            MessageBox.Show("se guardo correctamente cliente");
        }
    }
}
