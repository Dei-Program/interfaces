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
    public partial class ModMantenimiento : Form
    {
        public ModMantenimiento()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            RegistrarMantenimiento fo = new RegistrarMantenimiento();
            fo.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ActualizarMantenimeinto fo = new ActualizarMantenimeinto();
            fo.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            ConsultarMantenimiento fo = new ConsultarMantenimiento();
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
