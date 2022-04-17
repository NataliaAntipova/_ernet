using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6_urok
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите натуральные числа a и N");
            int a = int.Parse(Console.ReadLine());
            int N = int.Parse(Console.ReadLine());
            int res = a;
            for (int i = 1; i <= N; i++)
            {
                res++;
            }
            IEnumerable<int> seq;
            seq = System.Linq.Enumerable.Range(a, N);
            foreach (var x in seq)
                Console.WriteLine($"{x} ");

            /*zad_3*/
            /*int a = 1;
            int b = 9;
            int result = 0;
            for (int i = 1; i <= b; i++)
            {
            result += 2;
            }
            IEnumerable<int> seq;
            seq = System.Linq.Enumerable.Range(a, result);
            foreach (var x in seq)
            if (x % 2 != 0)
            {
            Console.WriteLine($"{x} ");
            }*/
        }
    }
}
