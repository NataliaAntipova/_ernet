using System;
using static System.Console;

namespace _10._5
{
    class Program
    {
        static void Main(string[] args)
        {
            WriteLine("Pel'meni");
            int[,] cirillaGif = new int[5, 5];


            FillMatrix(cirillaGif);
            Console.WriteLine("Матрица 5 x 5: ");
            PrintMatrix(cirillaGif);
            WriteLine();
            PlaceZero(cirillaGif);
            PrintMatrix(cirillaGif);


        }
        static void FillMatrix(int[,] cirillaGif, int minValue = -10, int maxValue = 10)
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

        static void PlaceZero(int[,] cirillaGif)
        {
            for (int i = 0; i < cirillaGif.GetLength(0); i++)
            {
                for (int j = 0; j<cirillaGif.GetLength(1); j++)
                {
                    if (i == 0 && j >= 0)
                    {
                        cirillaGif[i, j] = 0;
                    }
                    else if (i >= 0 && j == 0)
                    {
                        cirillaGif[i, j] = 0;
                    }
                    else if (i == 4 && j >= 0)
                    {
                        cirillaGif[i, j] = 0;
                    }
                    else if (i >= 0 && j == 4)
                    {
                        cirillaGif[i, j] = 0;
                    }
                }
            }
        }

    } 
}

