using System;

namespace Lesson_urok5m
{
    class urok5m
    {
        /*1 задание*/
        /*static void Main(string[] args)
        {
            Console.WriteLine("Введите значения для трех сторон треугольника: ");
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());
            Perimeter(a, b, c);
        }
        static void Perimeter(int a, int b, int c)
        {
            int perim = a + b + c;
            Console.WriteLine($"Периметр: {perim}");
        }*/


        /*2 задание*/
        /* static void Main(string[] args)
         {
             Console.WriteLine("Введите значения для трех сторон треугольника: ");
             int a = int.Parse(Console.ReadLine());
             int b = int.Parse(Console.ReadLine());
             int c = int.Parse(Console.ReadLine());
             Console.WriteLine("Периметр: " + Perimeter(a, b, c));
         }
         static int Perimeter(int a, int b, int c)
         {
             int perim = a + b + c;
             return perim;
         }*/

        /* 3 задание*/
        /* static void Main(string[] args)
         {
             Console.WriteLine("Введите координаты двух точек (четыре целых числа: x1, x2, y1, y2): ");
             int x1 = Int32.Parse(Console.ReadLine());
             int y1 = Int32.Parse(Console.ReadLine());
             int x2 = Int32.Parse(Console.ReadLine());
             int y2 = Int32.Parse(Console.ReadLine());
             Distance(x1, x2, y1, y2);
         }
         static void Distance(int x1, int x2, int y1, int y2)
         {
             int X = x2 - x1;
             int Y = y2 - y1;
             double res = Math.Sqrt(Math.Pow(X, 2) + Math.Pow(Y, 2));
             Console.WriteLine($"Расстояние: {res}");
         }*/

        /* 4 задание*/
        /*  static void Main(string[] args)
          {
              Console.WriteLine("Введите координаты двух точек (четыре целых числа: x1, x2, y1, y2): ");
              int x1 = Int32.Parse(Console.ReadLine());
              int y1 = Int32.Parse(Console.ReadLine());
              int x2 = Int32.Parse(Console.ReadLine());
              int y2 = Int32.Parse(Console.ReadLine());
              Console.WriteLine("Расстояние: " + Distance(x1, x2, y1, y2));
          }
          static double Distance(int x1, int x2, int y1, int y2)
          {
              int X = x2 - x1;
              int Y = y2 - y1;
              double res = Math.Sqrt(Math.Pow(X, 2) + Math.Pow(Y, 2));
              return res;
          }*/

    }
}

