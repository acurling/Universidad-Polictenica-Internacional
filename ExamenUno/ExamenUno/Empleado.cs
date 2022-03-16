using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenUno
{
    class Empleado
    {
        //ATRIBUTOS
        string[] cedulaEmpleado = new string[3];
        string[] nombreEmpleado = new string[3];
        int[] tipoEmpleado = new int[3];
        int[] cantidadHorasLaboradas = new int[3];
        float[] precioPorHora = new float[3];
        int pos;
        static string tEmpleado = "";


        //CONSTRUCTOR
        public Empleado() // constructor 
        {
            pos = 0;
        }
        public Empleado(int posicion) // constructor 
        {
            pos = posicion;
        }

        public void InicializarArreglos()
        {
            for (int i = 0; i < cedulaEmpleado.Length; i++)
            {
                cedulaEmpleado[i] = "";
                nombreEmpleado[i] = "";
                tipoEmpleado[i] = 0;
                cantidadHorasLaboradas[i] = 0;
                precioPorHora[i] = 0;
            }
            Console.WriteLine("Arreglos inicializados...");

        }
        public void IngresarDatosEmpleado()
        {
            char option;
            try
            {
                do
                {
                    Console.WriteLine("Ingrese la cedula del empleado: ");
                    cedulaEmpleado[pos] = Console.ReadLine();
                    Console.WriteLine("Ingrese el nombre del empleado: ");
                    nombreEmpleado[pos] = Console.ReadLine();
                    Console.WriteLine("Ingrese el tipo de empleado: ");
                    Console.WriteLine("1- Operario \n2- Técnico \n3- Profesional");
                    tipoEmpleado[pos] = int.Parse(Console.ReadLine());

                   
                    
                        switch (tipoEmpleado[pos])
                    {
                        case 1:
                            if (tipoEmpleado[0] == 1)
                            {
                                tEmpleado = "Operador";
                            }
                            System.Console.WriteLine("Ingrese la cantidad de horas laboradas: ");
                            cantidadHorasLaboradas[pos] = int.Parse(Console.ReadLine());
                            System.Console.WriteLine("Ingrese el precio por hora: ");
                            precioPorHora[pos] = float.Parse(Console.ReadLine());
                            

                            break;
                        case 2:
                            if (tipoEmpleado[1] == 2)
                            {
                                tEmpleado = "Técnico";
                            }
                            System.Console.WriteLine("Ingrese la cantidad de horas laboradas: ");
                            cantidadHorasLaboradas[pos] = int.Parse(Console.ReadLine());
                            System.Console.WriteLine("Ingrese el precio por hora: ");
                            precioPorHora[pos] = float.Parse(Console.ReadLine());
                            
                            break;
                        case 3:
                            if (tipoEmpleado[1] == 2)
                            {
                                tEmpleado = "Profesional";
                            }
                            System.Console.WriteLine("Ingrese la cantidad de horas laboradas: ");
                            cantidadHorasLaboradas[pos] = int.Parse(Console.ReadLine());
                            System.Console.WriteLine("Ingrese el precio por hora: ");
                            precioPorHora[pos] = float.Parse(Console.ReadLine());
                            

                            break;
                        default:
                            Console.WriteLine("Tipo de empleado no valido");
                            break;
                    }
                    Console.WriteLine("Desea ingresar otro empleado? (s/n)");
                    option = char.Parse(Console.ReadLine().ToLower());
                    pos++;
                } while (option == 's');
            }
            catch (Exception)
            {
                Console.WriteLine("Error, intentalo de nuevo");
                IngresarDatosEmpleado();
                throw;
            }
            



        }
        public void ConsultarDatosEmpleado()
        {
            bool encontrar = false;
            string cedula;
            Console.WriteLine("Ingrese la cedula del empleado a consultar: ");
            cedula = Console.ReadLine();
            for (int i = 0; i < cedulaEmpleado.Length; i++)
            {
                if (cedulaEmpleado[i] == cedula)
                {
                    Console.WriteLine("Cedula: " + cedulaEmpleado[i]);
                    Console.WriteLine("Nombre: " + nombreEmpleado[i]);
                    Console.WriteLine("Tipo de empleado: " + tipoEmpleado[i]);
                    Console.WriteLine("Cantidad de horas laboradas: " + cantidadHorasLaboradas[i]);
                    Console.WriteLine("Precio por hora: " + precioPorHora[i]);
                    Console.WriteLine("Salario: " + (cantidadHorasLaboradas[i] * precioPorHora[i]));
                    Console.WriteLine();
                    encontrar = true;
                }
                if (!encontrar)
                {
                    Console.WriteLine("Empleado no encontrado");
                    Console.WriteLine();
                }

            }
        }
        //Reporte de empleados
        public void ReporteEmpleados()
        {

            Console.WriteLine("----------------------------------------------------------------------------------------------------------------------");
            Console.WriteLine("Cedula\tNombre\tTipo de empleado\tCantidad de horas\tPrecio por hora\tSalario total");
            Console.WriteLine("----------------------------------------------------------------------------------------------------------------------");

            for (int i = 0; i < cedulaEmpleado.Length; i++)
            {
                    if (!cedulaEmpleado.Equals(""))
                    {
                        Console.WriteLine(cedulaEmpleado[i] + "\t" + nombreEmpleado[i] + "\t" + tEmpleado + "  \t" + cantidadHorasLaboradas[i] + "\t" + precioPorHora[i] + "\t" + (cantidadHorasLaboradas[i]*precioPorHora[i]));
                    }


                }
                Console.WriteLine("----------------------------------------------------------------------------------------------------------------------");
            }
        }
    }


