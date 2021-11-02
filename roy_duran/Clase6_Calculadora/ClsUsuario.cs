using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Clase6_Calculadora
{
    public class ClsUsuario
    {
        //Atributos
        private static string nombre { get; set; }
        private static int clave { get; set; }

        //Constructor
        public ClsUsuario(string Nombre, int Clave) {
            nombre = Nombre;
            clave = Clave;
        }

        public ClsUsuario() { } //constructor vacio

        public static string GetNombre()
        {
            return nombre;
        }

        public static void SetNombre(string Nombre)
        {
            ClsUsuario.nombre = Nombre;
        }

        public static int GetClave()
        {
            return clave;
        }

        public static void SetClave(int Clave)
        {
            ClsUsuario.clave = Clave;
        }

    }
}