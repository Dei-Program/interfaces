﻿using System;
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
    public partial class ConsultarFactura : Form
    {
        public ConsultarFactura()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            FacturacionMenu factmenu = new FacturacionMenu();
            factmenu.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            FacturacionMenu menu = new FacturacionMenu();
            menu.Show();
            this.Hide();
        }
    }
}