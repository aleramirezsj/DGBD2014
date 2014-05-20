using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProgramacionOrientadaAObjetos
{
    class Program
    {
        static void Main(string[] args)
        {
            //creamos el objeto mipersona basado en la
            //clase persona
            Persona mipersona = new Persona();
            int opcion = 0;
            //Muestro el menú
            while (opcion != 4)
            {
                Console.Clear();
                Console.WriteLine("MENU DE OPCIONES");
                Console.WriteLine("1- Carga de datos");
                Console.WriteLine("2- Imprimir Ficha de datos");
                Console.WriteLine("3- Imprimir Datos en un renglón");
                Console.WriteLine("4- Salir");
                Console.Write("Ingrese su opción:");
                try
                {
                    opcion = Convert.ToInt32(Console.ReadLine());
                }
                catch
                {
                    Console.WriteLine("Error... Ingrese una opción correcta");
                    Console.ReadKey();
                }
                switch (opcion)
                {
                    case 1:
                        mipersona.CargarDatos();
                        break;
                    case 2:
                        mipersona.ImprimirFicha();
                        break;
                    case 3:
                        mipersona.ImprimirRenglon();
                        break;
                    case 4:
                        break;
                    default:
                        Console.WriteLine("Error... Ingrese una opción correcta");
                        Console.ReadKey();
                        break;
                }
            }
            Console.WriteLine("Pulse una tecla para salir del programa");
            Console.ReadKey();
        }
    }
}
