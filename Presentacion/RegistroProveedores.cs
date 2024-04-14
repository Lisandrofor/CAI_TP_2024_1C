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
    public partial class RegistroProveedores : Form
    {
        public RegistroProveedores()
        {
            InitializeComponent();
        }

        private void btnVolverProveedor_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form formulario = new GestionProveedores();
            formulario.Show();
        }

        private void btnRegistrarProveedor_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form formulario = new GestionProveedores();
            formulario.Show();
        }
    }
}
