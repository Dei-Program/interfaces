using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication3
{
    public partial class ModClientes : Form
    {
        public ModClientes()
        {
            InitializeComponent();
        }

        private void Form10_Load(object sender, EventArgs e)
        {

        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }
        //
        private void nuevoClienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RegCliente fo = new RegCliente();
            fo.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            RegCliente fo = new RegCliente();
            fo.Show();
            this.Hide();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            MenuPrincipal fo = new MenuPrincipal();
            fo.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ActualizarCliente fo = new ActualizarCliente();
            fo.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            ConCliente fo = new ConCliente();
            fo.Show();
            this.Hide();
        }
    }
}
