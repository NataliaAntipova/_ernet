using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
namespace urok10_2_1
{
    class Program
    {
        static void Main(string[] args)
        {
           
            Console.WriteLine("введите кол-во строк");
            int rows = int.Parse(ReadLine());
            Console.WriteLine("введите кол-во столбцов");
            int columns = int.Parse(ReadLine());
            int[,] matrix = new int[rows, columns];
            int minValue = -15;
            int maxValue = 15;
            FillMatrix(matrix, minValue, maxValue);
            int max = int.MinValue;
            int min = int.MaxValue;
            FindMinMaxArr( matrix, ref  min, ref max);
             
            ReadKey();
        }
        
        private static void FillMatrix(int[,] matrix, int minValue = -15, int maxValue = 15)
        {
            Random rand = new Random();
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    matrix[i, j] = rand.Next(minValue, maxValue);
                    Write(matrix[i, j].ToString().PadLeft(4));
                }
                WriteLine();
            }

        }

        private static void FindMinMaxArr(int[,] matrix, ref int min, ref int max)
        {
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    if (matrix[i, j] > max && matrix[i, j] != 0) { max = matrix[i, j]; }
                    if (matrix[i, j] < min && matrix[i, j] != 0) { min = matrix[i, j]; }
                    
                }
                
            }
            Write($"min = {min};  max = {max}");
        }

    }
}
