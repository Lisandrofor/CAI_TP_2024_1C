//using accesoadatos.utilidades;
//using modelo;
//using system;
//using system.collections.generic;
//using system.io;
//using system.linq;
//using system.net.http;
//using system.text;
//using system.threading.tasks;
//using newtonsoft.json;

//namespace accesoadatos
//{
//    public static class usuariodatos
//    {
//        static string usuarioadmin = "70b37dc1-8fde-4840-be47-9ababd0ee7e5";


//        //post para login
//        public static string login(loginuser login)
//        {
//            var jsonrequest = jsonconvert.serializeobject(login);

//            httpresponsemessage response = webhelper.post("usuario/login", jsonrequest);

//            if (!response.issuccessstatuscode)
//            {
//                throw new exception("verifique los datos ingresados");
//            }

//            var reader = new streamreader(response.content.readasstream());

//            string respuesta = reader.readtoend();

//            return respuesta;
//        }


//        //post para agregar usuario

//        public static void agregarusuario(usuariows usuario)
//        {
//            var jsonrequest = jsonconvert.serializeobject(usuario);
//            httpresponsemessage response = webhelper.post("usuario/agregarusuario", jsonrequest);

//            if (!response.issuccessstatuscode)
//            {
//                throw new exception("verifique los datos ingresados. error al agregar usuario.");
//            }
//        }


//        //get para traer usuarios
//        public static list<usuariows> listarusuarios()
//        {

//            httpresponsemessage response = webhelper.get("usuario/traerusuariosactivos?id=" + usuarioadmin);

//            if (!response.issuccessstatuscode)
//            {
//                throw new exception("verifique los datos ingresados");
//            }
//            else
//            {
//                var contentstream = response.content.readasstringasync().result;
//                list<usuariows> listadousuarios = jsonconvert.deserializeobject<list<usuariows>>(contentstream);
//                return listadousuarios;

//            }
//        }


//        //patch cambiar contraseña

//        public static string cambiarcontraseña(string nombreusuario, string contraseña, string contraseñanueva)
//        {
//            dictionary<string, string> map = new dictionary<string, string>();
//            map.add("nombreusuario", nombreusuario);
//            map.add("contraseña", contraseña);
//            map.add("contraseñanueva", contraseñanueva);

//            var jsonrequest = jsonconvert.serializeobject(map);

//            httpresponsemessage response = webhelper.patch("usuario/cambiarcontraseña", jsonrequest);

//            if (!response.issuccessstatuscode)
//            {
//                throw new exception("verifique los datos ingresados");
//            }

//            var reader = new streamreader(response.content.readasstream());

//            string respuesta = reader.readtoend();

//            return respuesta;
//        }


//        //delete para baja de usuario

//        public static void borrarusuario(string idusuario, string idusuariomaster)
//        {
//            dictionary<string, string> map = new dictionary<string, string>();
//            map.add("id", idusuario);
//            map.add("idusuario", idusuariomaster);

//            var jsonrequest = jsonconvert.serializeobject(map);

//            httpresponsemessage response = webhelper.deleteconbody("usuario/bajausuario", jsonrequest);

//            if (!response.issuccessstatuscode)
//            {
//                throw new exception("verifique los datos ingresados");
//            }

//        }

       

//        //patch para reactivar usuario


//    }
//}
