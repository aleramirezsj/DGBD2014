using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProgramacionOrientadaAObjetos
{
    class SistemaClientes
    {
        public Persona cliente;
        private String tituloEmpresa;
        private String DatosEmpresa;

        public SistemaClientes()
        {
            InicioEmpresa();
            cliente = new Persona();
            MostrarMenu();
            
        }

        public void InicioEmpresa()
        {
            Console.WriteLine("Carga de datos de la empresa");
            Console.Write("Ingrese el nombre:");
            tituloEmpresa = Console.ReadLine();
            Console.Write("Ingrese datos de la empresa (TE, Dirección, Email):");
            DatosEmpresa = Console.ReadLine();
        }

        public void MostrarMenu()
        {
            int opcion = 0;
            //Muestro el menú
            while (opcion != 4)
            {
                Console.Clear();
                Console.WriteLine("SISTEMA DE CLIENTES :: "+tituloEmpresa);
                Console.WriteLine("1- Carga de cliente");
                Console.WriteLine("2- Imprimir Ficha de cliente");
                Console.WriteLine("3- Imprimir cliente en un renglón");
                Console.WriteLine("4- Salir");
                Console.Write("Ingrese su opción:");
                try
                {
                    opcion = Convert.ToInt32(Console.ReadLine());
                }
                catch
                {
                    Console.WriteLine("Error... Ingrese una opción correcta (Pulse cualquier tecla para continuar)");
                    Console.ReadKey();
                    continue;
                }
                switch (opcion)
                {
                    case 1:
                        cliente.CargarDatos();
                        break;
                    case 2:
                        cliente.ImprimirFicha();
                        break;
                    case 3:
                        cliente.ImprimirRenglon();
                        break;
                    case 4:
                        break;
                    default:
                        Console.WriteLine("Error... Ingrese una opción correcta (Pulse cualquier tecla para continuar)");
                        Console.ReadKey();
                        break;
                }
            }
            Console.WriteLine("Pulse una tecla para salir del programa");
            Console.ReadKey();
        }
    }
}
