using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Clase6_Calculadora
{
    public class ClsCalculadora
    {
        public static float num1 { get; set; }
        public static float num2 { get; set; }
        float resultado = 0;

        public ClsCalculadora(float n1, float n2) {
            num1 = n1;
            num2 = n2;
        }

        public float Sumar() {
            resultado = num1 + num2;
            return resultado;
        }
        public float Resar()
        {
            resultado = num1 - num2;
            return resultado;
        }

        public float respuesta() {
            return resultado;
        }
    }
}