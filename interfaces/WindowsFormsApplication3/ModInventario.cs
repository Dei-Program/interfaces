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
    public partial class ModInventario : Form
    {
        public ModInventario()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            RegProducto fo = new RegProducto();
            fo.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ElimiProducto fo = new ElimiProducto();
            fo.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ActualizarProducto fo = new ActualizarProducto();
            fo.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            ConsultarProducto fo = new ConsultarProducto();
            fo.Show();
            this.Hide();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            MenuPrincipal fo = new MenuPrincipal();
            fo.Show();
            this.Hide();
        }
    }
}
