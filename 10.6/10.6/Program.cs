using System;
using static System.Console;

namespace _10._6
{
    class Program
    {
        static void Main(string[] args)
        {
            WriteLine("Pel'meni");
            int[,] cirillaGif = new int[3, 4];

            FillMatrix(cirillaGif);
            Console.WriteLine("Матрица 3 x 4: ");
            PrintMatrix(cirillaGif);

            WriteLine("Введите номер пельменя");
            int m = Int32.Parse(Console.ReadLine());
            double product = 1;

            Write($"Произведение элементов {m} столбца равно ");
            FindProductOfColumn(cirillaGif, m, ref product);
        }

        static void FindProductOfColumn(int[,] cirillaGif, int m, ref double product)
        {
            for (int j = 0; j < cirillaGif.GetLength(1); j++)
            {
                if (j == m)
                {
                    for (int i = 0; i < cirillaGif.GetLength(0); i++)
                    {
                        product *= cirillaGif[i, j];
                    }
                }
            }
            WriteLine(product);
        }

        static void FillMatrix(int[,] cirillaGif, int minValue = -100, int maxValue = 100)
        {
            Random rand = new Random();
            for (int i = 0; i < cirillaGif.GetLength(0); i++)
            {
                for (int j = 0; j < cirillaGif.GetLength(1); j++)
                {
                    cirillaGif[i, j] = rand.Next(minValue, maxValue);
                }
            }
        }
        static void PrintMatrix(int[,] m)
        {
            for (int i = 0; i < m.GetLength(0); i++)
            {
                for (int j = 0; j < m.GetLength(1); j++)
                {
                    Console.Write(m[i, j].ToString().PadLeft(4));
                }
                Console.WriteLine();
            }
        }
        
    }
}
