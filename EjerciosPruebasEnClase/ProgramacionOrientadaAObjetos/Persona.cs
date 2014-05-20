using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProgramacionOrientadaAObjetos
{
    /// <summary>
    /// clase que carga los datos del usuario
    /// </summary>
    public class Persona
    {
        //definimos las propiedades de la clase
        private string nombre;
        private string direccion;
        private string dni;

        //método constructor de la clase
        //cuando se instancia la clase, se ejecuta
        public Persona()
        {
            Console.WriteLine("Clase persona creada en memoria");
        }

        /// <summary>
        /// pedimos los datos al usuario
        /// </summary>
        public void CargarDatos()
        {
           
            Console.WriteLine("CARGA DE DATOS");
            Console.Write("Ingrese su nombre:");
            nombre = Console.ReadLine();
            Console.Write("Ingrese su Dirección:");
            direccion = Console.ReadLine();
            Console.Write("Ingrese su DNI:");
            dni = Console.ReadLine();
        }

        /// <summary>
        /// imprimimos por pantalla los datos del usuario
        /// </summary>
        public void ImprimirFicha()
        {
            //
            Console.WriteLine("DATOS FICHA PERSONA:");
            Console.WriteLine("Nombre:" + nombre);
            Console.WriteLine("Dirección:" + direccion);
            Console.WriteLine("Dni:" + dni);
            Console.ReadKey();
        }

        /// <summary>
        /// imprimimos los datos en un renglón
        /// </summary>
        public void ImprimirRenglon()
        {
            Console.WriteLine("Usuario:{0} Dirección:{1} DNI:{2}", nombre, direccion, dni);
            Console.ReadKey();
        }
    }
}
