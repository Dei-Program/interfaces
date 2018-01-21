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
    public partial class FacturacionMenu : Form
    {
        public FacturacionMenu()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void holaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RegistrarFactura lo = new RegistrarFactura();
            lo.Show();
            this.Hide();
        }

        private void modificarFacturaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            

        }

        private void eliminarCancelarFacturaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            

        }

        private void button6_Click(object sender, EventArgs e)
        {
            MenuPrincipal menu = new  MenuPrincipal();
            menu.Show();
            this.Hide();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            RegistrarFactura lo = new RegistrarFactura();
            lo.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ConsultarFactura cfact = new ConsultarFactura();
            cfact.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            AnularFactura afact = new AnularFactura();
            afact.Show();
            this.Hide();
        }
    }
}
