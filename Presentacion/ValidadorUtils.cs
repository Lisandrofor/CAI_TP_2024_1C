using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace Presentacion
{
    internal class ValidadorUtils
    {


        public void validarTexto(string texto, string campo)
        {
            string msgError = "";
            msgError = msgError + validarVacio(texto, campo) + "/n";

            MessageBox.Show(msgError);
        }

        private string validarVacio(string texto, string campo)
        {
            if (texto.Length == 0)
            {
               
                return "El campo " + campo + " no puede estar vacio";
            }
            return "";
        }

        public string validarCUIT(string CUIT, string campo)
        {
            long numCUIT= -1;


            do
            {

                if (CUIT.Length == 0)
                {

                    return "El CUIT no puede estar vacio";
                }

                else if (CUIT.Length != 13)
                {

                    return "El CUIT no esta completo";
                }

                else if (CUIT.Substring(0,2)!= "20" || CUIT.Substring(0, 2) != "23" || CUIT.Substring(0, 2) != "24" || CUIT.Substring(0, 2) != "25" || CUIT.Substring(0, 2) != "26" || CUIT.Substring(0, 2) != "27" || CUIT.Substring(0, 2) != "30" || CUIT.Substring(0, 2) != "33" || CUIT.Substring(0, 2) != "34")
                {

                    return "El CUIT debe iniciar con los prefijos 20,23,24,25,26,27,30,33 o 34";
                }


                else if (!long.TryParse(CUIT, out numCUIT))
                {
                    Console.WriteLine("Debe ingresar un número válido");

                }

               

            } while (numCUIT == -1);

            return "";
       
            }
    }
}

