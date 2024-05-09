<<<<<<< HEAD
﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Negocio;
﻿



        private MenuPrincipalSupervisor menuSupervisor = new MenuPrincipalSupervisor();
        private MenuPrincipalAdministrador menuAdministrador = new MenuPrincipalAdministrador();
        private MenuPrincipalVendedor menuVendedor = new MenuPrincipalVendedor();
     

        private void Login_Load(object sender, EventArgs e)
        {
=======

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            
           ValidadorLogin validador = new ValidadorLogin();
            string usuarioActualTipo = tbName.Text;
            string contraseñaActual = tbContraseña.Text;
            if (usuarioActualTipo == "v")
            {
                menuVendedor = new MenuPrincipalVendedor();
                this.Hide();
                menuVendedor.Show();

            }
            else if (usuarioActualTipo == "s")
            {
                menuSupervisor = new MenuPrincipalSupervisor();
                this.Hide();
                menuSupervisor.Show();
            }
            else if (usuarioActualTipo == "a")
            {
                menuAdministrador = new MenuPrincipalAdministrador();
                this.Hide();
                menuAdministrador.Show();
            }
            else if (usuarioActualTipo == "" || contraseñaActual == "" )
            {
                validador.ValidacionLogin();
            }

           
           
        }

        private void tbName_TextChanged(object sender, EventArgs e)
        {
            

            
        }
    }
}

