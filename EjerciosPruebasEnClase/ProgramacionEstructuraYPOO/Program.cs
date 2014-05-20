using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProgramacionEstructurada
{
    class Program
    {
        static void Main(string[] args)
        {
            //declaramos las variables
            string nombre;
            string direccion;
            string dni;

            //pedimos los datos al usuario
            Console.Write("Ingrese su nombre:");
            nombre=Console.ReadLine();
            Console.Write("Ingrese su Dirección:");
            direccion = Console.ReadLine();
            Console.Write("Ingrese su DNI:");
            dni = Console.ReadLine();

            //imprimimos por pantalla los 
            //datos del usuario
            Console.WriteLine("Los datos del usuario son:");
            Console.WriteLine("Nombre:" + nombre);
            Console.WriteLine("Dirección:" + direccion);
            Console.WriteLine("Dni:" + dni);
            
            //imprimimos los datos en un renglón
            //Console.WriteLine("Usuario:" + nombre + "  Dirección:" + direccion + "  DNI:" + dni);
            Console.WriteLine("Usuario:{0} Dirección:{1} DNI:{2}", nombre, direccion, dni);
            Console.ReadKey();

        }
    }
}
