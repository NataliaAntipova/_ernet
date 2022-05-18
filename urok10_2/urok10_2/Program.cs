using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace urok10_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] arr = new int[2, 3];

            int sum = 0;
            Console.WriteLine("Введите 6 значений для матрицы");
            for (int i = 0; i < 2; i++)
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
                    sum += arr[i, j];

                }
                Console.WriteLine();
            }
            Console.WriteLine("Сумма: " + sum);

            Console.ReadKey();
        }
    }
}
