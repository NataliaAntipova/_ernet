using System;
using static System.Console;
namespace Lesson7_Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[15];

            FillArray(arr);
            Print(arr);

            WriteLine("Введите число N: ");
            int N = int.Parse(ReadLine());
            FindN(arr, N);
        }

        static void Print(int[] array) //Вывод массива
        {
            foreach (var i in array)
                Write(i + " ");
            WriteLine();
        }

        static void FillArray(int[] arr) //Заполнить массив случайными числами
        {
            Random rand = new Random();
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = rand.Next(1, 10);
            }
        }

        static void FindN(int[] arr, int N)
        {
            bool f = false;
            int counter = 0;
            int n_counter = 0;
            foreach (int i in arr)
            {
                if (i == N)
                {
                    f = true;
                    n_counter = counter;
                    break;
                }
                counter++;
            }
            if (f)
            {
                WriteLine("Результат: да");
                WriteLine($"Индекс: {n_counter}");
            }
            else
            {
                WriteLine("Результат: нет");
            }
        }
    }
}
