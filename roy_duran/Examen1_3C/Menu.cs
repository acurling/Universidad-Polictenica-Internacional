using System;
using System.Collections.Generic;
using System.Text;

namespace Examen1_3C
{
    class Menu
    {

        static Pago pago = new Pago(); //instanciar clase como static
        public static void principal()
        {
            int opcion = -1;
            do
            {
                Console.WriteLine("*****MENU PRINCIPAL******");
                Console.WriteLine("=========================");
                Console.WriteLine(" 1- Inicializar arreglos");
                Console.WriteLine(" 2- Realizar pago");
                Console.WriteLine(" 3- Consultar pagos");
                Console.WriteLine(" 4- Modificar pagos");
                Console.WriteLine(" 5- Eliminar pagos");
                Console.WriteLine(" 6- Reporte pagos");
                Console.WriteLine(" 7- Salir");
                Console.WriteLine("==========================");
                Console.WriteLine("");
                Console.WriteLine("Digite una opcion:" + (opcion = (int.Parse(Console.ReadLine()))));
                switch (opcion)
                {
                    case 1:
                        pago.InicializarVectores();
                        break;
                    case 2:
                        pago.AgregarPago();
                        break;
                    case 3:
                        pago.ConsultarPago();
                        break;
                    case 4:
                        pago.Reporte();
                        break;
                    case 5:
                        reportes();
                        break;
                    case 6:
                        reportes();
                        break;
                    default:
                        Console.WriteLine("La opcion escogida no es correcta");
                        break;
                }
            } while (opcion != 7);
        }
        public static void reportes()
        {
            int opcion = -1;
            do
            {
                Console.WriteLine("************SUBMENU REPORTES***********");
                Console.WriteLine("=======================================");
                Console.WriteLine("1 - Ver todos los pagos");
                Console.WriteLine("2 - Ver pagos por tipo de servicio");
                Console.WriteLine("3 - Ver pago por codigo de caja");
                Console.WriteLine("4 - Ver dinero comisionado por servicios");
                Console.WriteLine("5 - Regresar al menu principal");
                Console.WriteLine("=======================================");
                Console.WriteLine("Digite una opcion:" + (opcion = (int.Parse(Console.ReadLine()))));
                switch (opcion)
                {
                    case 1:
                        pago.ConsultarPago();
                        break;
                    case 2:
                        pago.Reporte();
                        break;
                    default:
                        Console.WriteLine("La opcion escogida no es correcta");
                        break;

                }
            } while (opcion != 5);
        }
    }
}
