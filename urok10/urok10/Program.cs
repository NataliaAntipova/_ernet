using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace urok10
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] arr1 = {
                {-8,-14,-19,-18},
                { 25,28, 26, 20},
                { 11,18, 20, 25}
                };

            /* 1 задание*/
            Console.WriteLine("Задание 1");
            System.Console.WriteLine($" {arr1[1, 3]}, {arr1[2, 0]}");


            /* 2 задание*/
            Console.WriteLine("Задание 2");
            for (int i = 0; i < 1; i++)
            {
                for (int j = 0; j < 1; j++)
                {
                    Console.WriteLine($" {arr1[1, 0]}, {arr1[1, 1]}, {arr1[1, 2]}, {arr1[1, 3]}");
                }
            }

            /* 3 задание*/
            Console.WriteLine("Задание 3");
            for (int i = 0; i < arr1.GetLength(0); i++)
            {
                for (int j = 0; j < arr1.GetLength(1); j++)
                {
             
                Console.Write($"{arr1[i, j]}  "); 
                   
               }
               Console.WriteLine();
           }

            /*4 задание */
            Console.WriteLine("Задание 4");
            for (int i = 0; i < 1; i++)
            {
                Console.WriteLine((arr1[2, 0] + arr1[2, 1] + arr1[2, 2] + arr1[2, 3])/ arr1.GetLength(1));
            }

            /* 5 задание */
            Console.WriteLine("Задание 5");
            for (int i = 0; i < arr1.GetLength(0); i++)
            {
                for (int j = 0; j < arr1.GetLength(1); j++)
                {
                    if
                        (arr1[i, j] > 24)
                    if
                        (arr1[i, j] <= 26)

                     Console.Write($" станция =  {i}; день = {j}  " );
                    

                }
                Console.WriteLine();
            }

            Console.ReadKey();
        }
    }
}
