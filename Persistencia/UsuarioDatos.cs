using Modelo;
using Newtonsoft.Json;
using PersistenciaWS;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace Persistencia
{
    public class UsuarioDatos
    {

        static String usuarioAdmin = "70b37dc1-8fde-4840-be47-9ababd0ee7e5";
        public static void AgregarUsuario(UsuarioWs usuario)
        {
            var jsonRequest = JsonConvert.SerializeObject(usuario);
            HttpResponseMessage response = WebHelper.Post("Usuario/AgregarUsuario", jsonRequest);

            if (!response.IsSuccessStatusCode)
            {
                throw new Exception("Verifique los datos ingresados. Error al agregar usuario.");
            }
        }
    }
}
