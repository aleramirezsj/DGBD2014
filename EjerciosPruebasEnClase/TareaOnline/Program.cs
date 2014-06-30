
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
 
 
namespace TareaOnline
{   
    class Program 
    {     
        static void Main(string[] args)     
        {           
            //Se declaran las variables         
            int[,] A = new int[2, 2];         
            int[,] B = new int[2, 2];        
            int[,] C = new int[2, 2];
 
 
            Console.WriteLine ("TAREA ONLINE Nº2: SUMA DE MATRICES");         
            Console.WriteLine("");
 
 
            //Se ingresan los valores de cada matriz (A y B)
            
            CargaMatriz(A, 3, 3,"A");

            CargaMatriz(B, 3, 7,"B");
            
            //Se suman las dos matrices A+B         
             Console.WriteLine("La suma de la matriz A y B es:");           
             Console.WriteLine("");         
            for (int i=0; i<2;i++)
            {         
 
                Console.WriteLine();           
                for (int k=0; k<2;k++)
                {     
 
                    C[i,k]=A[i,k] + B[i,k];                 
                    Console.Write (C[i,k].ToString("| 00 |") + "");         
                }     
            }
 
 
            Console.ReadKey();     
        }//main 
        
        static void CargaMatriz(int[,] matriz,int left, int top,string nombreMatriz)
        {
            //Se ingresan los valores de la matriz           
            Console.WriteLine("Ingrese los valores de la matriz "+nombreMatriz+" de 2x2:");

            for (int i = 0; i < 2; i++)
            {
                for (int z = 0; z < 2; z++)
                {
                    Console.SetCursorPosition(left+(3*z), top+(2*i));
                    matriz[i, z] = Convert.ToInt32(Console.ReadLine());
                }
            }
        }//CargaMatriz
    }//class
}//namespace


