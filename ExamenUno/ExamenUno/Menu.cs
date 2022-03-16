using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenUno
{
    class Menu
    {
        static Empleado empleado = new Empleado(0);
        public void MenuP()
        {
            int opcion = 0;
            do
            {
                Console.WriteLine("1- Inicializar Arreglos");
                Console.WriteLine("2- Ingresar datos de empleado");
                Console.WriteLine("3- Consultar datos de empleado");
                Console.WriteLine("4- Reporte de empleados");
                Console.WriteLine("5- Salir");
                opcion = int.Parse(Console.ReadLine());
                switch (opcion)
                {
                    case 1:
                        empleado.InicializarArreglos();
                        break;
                    case 2:
                        empleado.IngresarDatosEmpleado();
                        break;
                    case 3:
                        empleado.ConsultarDatosEmpleado();
                        break;
                    case 4:
                        empleado.ReporteEmpleados();
                        break;
                    case 5:
                        break;
                    default:
                        Console.WriteLine("Ingrese una opcion valida");
                        break;
                }
            } while (opcion != 5);
        }
    }
}
