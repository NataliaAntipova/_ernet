using System;
using static System.Console;

namespace Lesson_7Task3
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] arr = new double[10];
            FillArray(arr);
            Sum(arr);
        }
        static void FillArray(double[] arr) //Заполнить массив случайными числами, вывести его
        {
            Random rand = new Random();
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = rand.NextDouble() * 10 - 5;
            }
            foreach (var i in arr)
                Write("{0:0.00} ", i);
            WriteLine();
        }

        static void Sum(double[] arr) //Найти суммы троек arr[1] + arr[2] + arr[3]; arr[2] + arr[3] + arr[4] и т.д.
        {
            double j = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                try
                {
                    j = arr[i] + arr[i + 1] + arr[i + 2];
                }
                catch
                {
                    continue;
                }

                WriteLine("{0:0.00}", j);
            }
        }
    }
}