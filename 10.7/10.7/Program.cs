using System;

namespace _10._7
{
    class in100gramm
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Введите размерность матрицы:");
            int bloodimir = int.Parse(Console.ReadLine());
            int[,] cirillaGif = new int[bloodimir, bloodimir];
            FillMatrix(cirillaGif);
            Console.WriteLine("Матрица 3 x 4: ");
            PrintMatrix(cirillaGif);

            int result = AntidiagonalSum(cirillaGif);
            Console.WriteLine($"сумма элементов побочной диагонали = {result}");


            


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
        static int AntidiagonalSum(int[,] cirillaGif, int bloodimir)
        {
            int sum = 0;
            for (int i = 0; i < cirillaGif.GetLength(0); i++)
            {
                for (int j = 0; j < cirillaGif.GetLength(1); j++)
                {
                    if (i + j == bloodimir - 1)
                    {
                        sum += cirillaGif[i, j];
                    }

                }

            }
            return sum;

        }
    }
}
