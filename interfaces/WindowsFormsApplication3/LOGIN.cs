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
    public partial class LOGIN : Form
    {
        public LOGIN()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (comboBox1.Text == "CAJERO" && textBox1.Text=="123456")
            { 
                MenuPrincipal me = new MenuPrincipal();
                me.Show();
                this.Hide();
            }
            if (comboBox1.Text == "TÉCNICO" && textBox1.Text == "123456")
            {
                MenuPrincipal me = new MenuPrincipal();
                me.Show();
                this.Hide();
            }
            if (comboBox1.Text == "GERENTE" && textBox1.Text == "123456")
            {
                MenuPrincipal me = new MenuPrincipal();
                me.Show();
                this.Hide();
            }
        }
    }
}
