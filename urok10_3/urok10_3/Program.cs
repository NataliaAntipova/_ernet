using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace urok10_3
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] arr = new int[4, 3];

           
            Console.WriteLine("Введите 12 значений для матрицы");
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    arr[i, j] = Int32.Parse(Console.ReadLine());

                }

            }
            Console.WriteLine("Матрица:");
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    
                    Console.Write($"{arr[i, j]}  ");
                    

                }
                Console.WriteLine();
            }

            int pol = 0;
            Console.Write("Положительные числа: ");
            for (int i = 0; i < arr.GetLength(0); ++i)
            {
                for (int j = 0; j < arr.GetLength(1); ++j)
                {
                    if (arr[i, j] > 0)
                    {
                        pol++;
                    }
                }
            }
            Console.Write(pol);
            Console.ReadKey();
        }
    }
}
