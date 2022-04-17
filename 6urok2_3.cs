using System;

namespace Lesson7_Task1
{
    class L7Task1
    {
        static void Main(string[] args)
        {
            double[] arr = { 1.1, 2.3, 3.7, 4.1, 5.6, 6.1, 7.1 };
            Print(arr);
            FindMinMax(arr);
        }

        static void Print(double[] array)
        {
            foreach (var i in array)
                Console.Write(i + " ");
            Console.WriteLine();
        }

        static void FindMinMax(double[] array)
        {
            double max = double.MinValue;
            double min = double.MaxValue;
            foreach (var i in array)
            {
                if (i < min)
                {
                    min = i;
                }
            }
            foreach (var i in array)
            {
                if (i > max)
                {
                    max = i;
                }

                Console.WriteLine($"Минимальное {min}, Максимальное {max}");

            }
        }
    }
}