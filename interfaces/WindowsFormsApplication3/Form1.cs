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
    public partial class Form1 : Form
    {
        public Form1()
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
            Form2 lo = new Form2();
            lo.Show();
        }

        private void modificarFacturaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form7 fo = new Form7();
            fo.Show();

        }

        private void eliminarCancelarFacturaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form6 fo = new Form6();
            fo.Show();

        }
    }
}
