using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CalculoDiasDeVida
{
    class Program
    {
        static void Main(string[] args)
        {
            # region declaramos las variables
                string nombre;
                byte edad;
                int dias;
            # endregion

            Console.WriteLine("Ejercicio Nº1:Cálculo días de vida");
            Console.WriteLine("***********************************");
            
            //Utilizamos Write para imprimir sin el enter al 
            //final
            Console.Write("Ingrese su nombre:");

            //le asignamos a la variable nombre el texto que 
            //escriba el usuario en la consola, 
            nombre = Console.ReadLine();
            
            Console.Write("Ingrese su edad:");
            
            //utilizamos el método toByte para convertir
            //el texto que entrega ReadLine en Byte, es decir
            //en un número
            edad = Convert.ToByte(Console.ReadLine());
            dias = edad * 365;

            Console.WriteLine("Hola " + nombre);
            Console.WriteLine("Los días de vida aproximados son:" + dias.ToString());
            Console.ReadKey();
        }
    }
}
