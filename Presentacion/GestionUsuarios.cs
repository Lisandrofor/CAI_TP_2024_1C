﻿//using System;
//using System.Collections.Generic;
//using System.ComponentModel;
//using System.Data;
//using System.Drawing;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
//using System.Windows.Forms;

//namespace Presentacion
//{
//    public partial class GestionUsuarios : Form
//    {
//        public GestionUsuarios()
//        {
//            InitializeComponent();
//        }

//        private void GestionUsuarios_Load(object sender, EventArgs e)
//        {

//        }

//        private void pictureBox2_Click(object sender, EventArgs e)
//        {

//        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form formulario = new MenuPrincipalAdministrador();
            formulario.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

//        }

        private void btnRegistrarUsuario_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form formulario = new RegistroUsuarios();
            formulario.Show();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void btnRegistroUsuarios_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form formulario = new ModificacionUsuario();
            formulario.Show();
        }

        private void btnBajaUsuario_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form formulario = new BajaUsuario();
            formulario.Show();
        }
    }
}
