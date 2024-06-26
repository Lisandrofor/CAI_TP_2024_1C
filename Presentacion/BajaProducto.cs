﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentacion
{
    public partial class BajaProducto : Form
    {
        public BajaProducto()
        {
            InitializeComponent();
        }

        private void btnBajaProducto_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form formulario = new RegistroProducto();
            formulario.Show();
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form formulario = new GestionProductos();
            formulario.Show();
        }
    }
}
