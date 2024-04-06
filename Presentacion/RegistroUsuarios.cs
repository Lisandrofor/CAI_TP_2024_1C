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
    public partial class RegistroUsuarios : Form
    {
        public RegistroUsuarios()
        {
            InitializeComponent();
        }

        private void RegistroUsuarios_Load(object sender, EventArgs e)
        {

        }

        private void btnRegistrarUsuario_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form formulario = new GestionUsuarios();
            formulario.Show();
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form formulario = new GestionUsuarios();
            formulario.Show();
        }
    }
}
