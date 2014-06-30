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
            #region ejercicio1_arreglos
            /*
            string continuar = "si";
            string[] nombre = new string[3];
            string[] direccion = new string[3];
            string[] dni = new string[3];

            //declaramos las variables
            for (int encuesta=0;encuesta<3;encuesta++)
            {
                
                
                Console.WriteLine("Carga de encuesta Nº" + (encuesta+1));
                //pedimos los datos al usuario
                Console.Write("Ingrese su nombre:");
                nombre[encuesta] = Console.ReadLine();
                Console.Write("Ingrese su Dirección:");
                direccion[encuesta] = Console.ReadLine();
                Console.Write("Ingrese su DNI:");
                dni[encuesta] = Console.ReadLine();

                //imprimimos por pantalla los 
                //datos del usuario
                Console.WriteLine("Los datos del usuario son:");
                Console.WriteLine("Nombre:" + nombre[encuesta]);
                Console.WriteLine("Dirección:" + direccion[encuesta]);
                Console.WriteLine("Dni:" + dni[encuesta]);

                //imprimimos los datos en un renglón
                //Console.WriteLine("Usuario:" + nombre + "  Dirección:" + direccion + "  DNI:" + dni);
                
                //Console.Write("¿Desea continuar?(si/no):");
                continuar = Console.ReadLine();
                Console.Clear();
            }
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine("Usuario:{0} Dirección:{1} DNI:{2}", nombre[i], direccion[i], dni[i]);
            }
            Console.ReadKey();
             */
            #endregion
            
            #region ejercicio2_arreglos
            /*
            int nro_encuestas = 0;
            Console.Write("Ingrese el Nº de encuestas:");
            nro_encuestas = Convert.ToInt32(Console.ReadLine());
            //creamos el arreglo basandonos en la variable
            //nro_encuestas que ingresa el usuario
            int [] encuestas= new int[nro_encuestas];

            CargaDeEncuestas(nro_encuestas, encuestas);
            float promedio = 0;
            promedio = CalcularPromedio(nro_encuestas,encuestas);
            Console.WriteLine("El promedio de alturas ingresadas es:" + promedio);
            ImprimirEncuestas(nro_encuestas, encuestas);
            Console.ReadKey();

          


        }
        static void ImprimirEncuestas(int nro_enc, int[] encts)
        {
            for (int z = 0; z < nro_enc; z++)
            {
                Console.WriteLine("Encuesta Nº:" + (z + 1) + " Altura:" + encts[z]);
            }
        }

        static float CalcularPromedio(int nro_enc, int[] encts)
        {
            //calculo de total y promedio de altura
            float total = 0;
            for (int k = 0; k < nro_enc; k++)
            {
                total += encts[k];
            }
            return total / nro_enc;
        }

        static void CargaDeEncuestas(int nro_enc, int[] encts)
        {
            //carga de encuestas
            for (int i = 0; i < nro_enc; i++)
            {
                Console.WriteLine("Encuesta Nro:" + (i + 1));
                Console.Write("Ingrese su altura en cms:");
                encts[i] = Convert.ToInt32(Console.ReadLine());
                Console.Clear();
            }
        */
            #endregion
            #region ejercicio3_matriz5x5
            /*
            int [,] tablero = new int[5, 5];
            int multiplo_2 = 2;
            Console.WriteLine("La matriz de 5x5 con sus multiplos de 2 es");
           
            //Los dos ciclos for que hacen el recorrido de la matriz
            for (int i = 0; i < 5; i++)
            {
                for (int k = 0; k < 5; k++)
                {
                    tablero[i,k] = multiplo_2;
                    multiplo_2 += 2;
                }
            }
            //Los dos ciclos for para hacer la impresión
            for (int i = 0; i < 5; i++)
            {
                for (int k = 0; k < 5; k++)
                {
                    Console.Write(tablero[i, k].ToString("|00|") + " ");
                }
                Console.WriteLine();
            }
            Console.ReadKey();
            */
            #endregion
            tarea_online_1();

        }
        static void tarea_online_1()
        {
            Console.WriteLine("TAREA ONLINE Nº1 - UTILIZANDO Console.SetCursorPosition");

            Console.SetCursorPosition(3, 3);
            Console.WriteLine("FICHA DE CLIENTE");
            Console.SetCursorPosition(3, 4);
            Console.WriteLine("===========================================================");
            Console.SetCursorPosition(3, 6);
            Console.Write("Nombre:");
            Console.ReadLine();

            Console.SetCursorPosition(40, 6);
            Console.Write("Apellido:");
            Console.ReadLine();

            Console.SetCursorPosition(3, 9);
            Console.Write("Dirección:");
            Console.ReadLine();

            Console.SetCursorPosition(40, 9);
            Console.Write("DNI:");
            Console.ReadLine();
        }
    }
}

