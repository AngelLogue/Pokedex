using System;
using System.Collections.Generic;
using System.Text;
using Firebase.Database;

namespace MvvmGuia.Conexion
{
    internal class Cconexion
    {
        public static FirebaseClient firebase = new FirebaseClient("https://mvvmguia-69303-default-rtdb.firebaseio.com/");
    }
}
