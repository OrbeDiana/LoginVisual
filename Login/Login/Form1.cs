﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Login
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

        private void Button1_Click(object sender, EventArgs e)
        {
            string usuario, contra;

            usuario = textBox1.Text;
            contra = textBox2.Text;

            if (usuario == "juancho" && contra == "123tamarindo")
            {
                MessageBox.Show("Has iniciado sesión Juancho");
            }
            else
            {
                MessageBox.Show("Quien eres tu? Este no es Juancho");
            }
        }
    }
}
