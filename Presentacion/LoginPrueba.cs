using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentacion
{
    public partial class LoginPrueba : Form
    {
        public LoginPrueba()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            TextReader leer = new StreamReader("BaseUsuarios.txt");



            leer.Close();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
