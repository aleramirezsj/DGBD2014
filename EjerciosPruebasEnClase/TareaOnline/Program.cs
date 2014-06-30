
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
 
 
            //Se ingresan los valores de la matriz A           
            Console.WriteLine ("Ingrese los valores de la matriz A de 2x2:");
 
 
            Console.SetCursorPosition (3,3);     
            A[0,0]= Convert.ToInt32(Console.ReadLine());
 
 
            Console.SetCursorPosition (6,3);           
            A[0,1]= Convert.ToInt32(Console.ReadLine());
 
 
            Console.SetCursorPosition (3,5);           
            A[1,0]= Convert.ToInt32(Console.ReadLine());
 
 
            Console.SetCursorPosition (6,5);           
            A[1,1]= Convert.ToInt32(Console.ReadLine());
 
 
            //Se ingresan los valores de la matriz B         
             Console.WriteLine ("Ingrese los valores de la matriz B de 2x2:");
 
 
            Console.SetCursorPosition (3,7);           
            B[0, 0] = Convert.ToInt32(Console.ReadLine());
 
 
            Console.SetCursorPosition(6,7);           
            B[0,1]=Convert.ToInt32(Console.ReadLine());
 
 
            Console.SetCursorPosition(3,9);           
            B[1,0]=Convert.ToInt32(Console.ReadLine());
 
 
            Console.SetCursorPosition(6,9);           
            B[1,1]=Convert.ToInt32(Console.ReadLine());
 
 
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
        } 
    }
}
