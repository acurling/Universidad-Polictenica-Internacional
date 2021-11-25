using System;
using System.Collections.Generic;
using System.Text;

namespace Examen1_3C
{
    class Pago
    {
        //atributos
        string[] numeroCaja = new string[10];
        string[] numeroPago = new string[10];
        string[] fecha = new string[10];
        string[] hora = new string[10];
        string[] cedula = new string[10];
        string[] nombre = new string[10];
        string[] apellido1 = new string[10];
        string[] apellido2 = new string[10];
        string[] tipoServicio = new string[10];
        string[] numeroFactura = new string[10];
        float[] montoPago = new float[10];
        float[] montoComision = new float[10];
        float[] montoDeducido = new float[10];
        float[] montoPagoCliente = new float[10];
        float[] vuelto = new float[10];

        int pos = 0;

        //constructor
        public Pago() //constructor sin parametros
        {
            pos = 0;
        }

        public Pago(int posicion)
        {
            pos = posicion;
        }

        public void InicializarVectores()
        {
            for (int i = 0; i < numeroPago.Length; i++)
            {
                numeroCaja[i] = "";
                numeroPago[i] = "";
                fecha[i] = "";
                hora[i] = "";
                cedula[i] = "";
                nombre[i] = "";
                apellido1[i] = "";
                apellido2[i] = "";
                numeroCaja[i] = "";
                tipoServicio[i] = "";
                numeroFactura[i] = "";
                montoPago[i] = 0;
                montoComision[i] = 0;
                montoDeducido[i] = 0;
                montoPagoCliente[i] = 0;
                vuelto[i] = 0;

            }
            Console.WriteLine("Arreglos inicializados...");
        }
        public void AgregarPago()
        {
            char opcion;
            do
            {

                Console.WriteLine("Digite la cedula: ");
                cedula[pos] = Console.ReadLine();
                Console.WriteLine("Digite el Nombre: ");
                nombre[pos] = Console.ReadLine();
                //CalculoPromedio();
                pos++;
                Console.WriteLine("Desea continuar: ");
                opcion = Convert.ToChar(Console.ReadLine());
            } while (opcion != 'n');
        }
        public void Reporte()
        {
            Console.WriteLine("**REPORTE DE PAGOS**");
            Console.WriteLine("NOMBRE       CEDULA       PROMEDIO       CONDICION");
            Console.WriteLine("----------------------------------------------------");
            for (int i = 0; i < numeroPago.Length; i++)
            {
                Console.WriteLine($"{nombre[i]}     {cedula[i]}");
            }
            Console.WriteLine("----------------------------------------------------");

        }
        public void ConsultarPago()
        {
            Boolean existe = false;
            Console.WriteLine("Digite numero de pago: ");
            string documento = Console.ReadLine();
            for (int i = 0; i < numeroPago.Length; i++)
            {
                if (documento.Equals(numeroPago[i]))
                {
                    Console.WriteLine($"Datos del pago: {tipoServicio[i]}");
                    existe = true;
                }
            }
            if (!existe)
            {
                Console.WriteLine("El pago consultado no existe");
                Console.WriteLine();
            }
        }
        public void ConsultarPagoTipo()
        {
            Boolean existe = false;
            Console.WriteLine("Digite el tipo de pago a consultar ");
            string tipo = Console.ReadLine();
            Console.WriteLine($"Tipo de sevicio: {tipo}");
            Console.WriteLine("====================================");
            for (int i = 0; i < tipo.Length; i++)
            {
                if (tipo.Equals(tipoServicio[i]))
                {
                    Console.WriteLine(nombre[i]);
                    existe = true;
                }
            }
            if (!existe)
            {
                Console.WriteLine("El Pago no existe");
                Console.WriteLine();
            }
        }
        public void ModificarPago() { }
        public void EliminarPago() { }
        public void CalculoComision() { }
        public void NumeroPago() { }
    }
}
