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
    public partial class ActualizarProducto : Form
    {
        public ActualizarProducto()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ModInventario fo = new ModInventario();
            fo.Show();
            this.Hide();
        }
    }
}
