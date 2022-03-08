namespace _2_urok.purple
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Console.WriteLine("Введите число");
            int numb = Int32.Parse(Console.ReadLine());
            if (numb > 0)
            {
            Console.WriteLine("Введенное число положительное");
            }
            else
            {
            Console.WriteLine("Введенное число отрицательное");
            }
            Console.ReadKey();*/

            /* Console.WriteLine("Введите число");
            int numb = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Результат: десятки = " + numb / 10 + ", единицы = " + numb % 10);
            Console.ReadKey();*/

            /*Console.WriteLine("Введите трехзначное число: ");
            int numb = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Цифры числа:" + numb / 100 + " , " + (numb / 10) % 10 + ", " + numb % 10);
            Console.WriteLine("Результат: " + numb/100 + numb*0 + numb%10);
            Console.ReadKey();*/

            /*Console.WriteLine("Введите три целых чисел");
            int numb_1 = Int32.Parse(Console.ReadLine());
            int numb_2 = Int32.Parse(Console.ReadLine());
            int numb_3 = Int32.Parse(Console.ReadLine());
            if (numb_1 != numb_2 && numb_1 != numb_3)
            {
            Console.WriteLine("Результат: " + true);
            }
            else
            {
            Console.WriteLine("Результат: " + false);
            }
            Console.ReadKey();*/

            /*Console.WriteLine("Введите три целых чисел");
            double a = Double.Parse(Console.ReadLine());
            double b = Double.Parse(Console.ReadLine());
            double c = Double.Parse(Console.ReadLine());
            double p = (a + b + c) / 2;
            double ok = Math.Sqrt((p * (p - a) * (p - b) * (p - c)));
            if (a+b>c&&b+c>a&&c+a>b)
            {
            Console.WriteLine("Результат: существует, его площать " + ok);
            }
            else
            {
            Console.WriteLine("Результат: не существует");
            }
            Console.ReadKey();*/
            /*Console.WriteLine("Введите число");
            int x = Int32.Parse(Console.ReadLine());
            int a = 2 * x;
            int b = -3 * x;
            if ((x < (-2)) || (x > 2))
            {
            Console.WriteLine($"Результат: {a}");
            }
            else
            {
            Console.WriteLine($"Результат: {b}");
            }
            Console.ReadKey();*/

            /*Console.WriteLine("Введите число:");
            int x = Int32.Parse(Console.ReadLine());
            double a = 2 * Math.Sin(x);
            int b = 6-x;
            if (x>0)
            {
            Console.WriteLine($"Результат: {a}");
            }
            else
            {
            Console.WriteLine($"Результат: {b}");
            }
            Console.ReadKey(); */

            Console.WriteLine("Введите число от 1 до 7: ");
            int x = Int32.Parse(Console.ReadLine());
            switch (x)
            {
            case 1:
            Console.WriteLine("Понедельник");
            Console.ReadKey();
            break;
            case 2:
            Console.WriteLine("Вторник");
            Console.ReadKey();
            break;
            case 3:
            Console.WriteLine("Среда");
            Console.ReadKey();
            break;
            case 4:
            Console.WriteLine("Четверг");
            Console.ReadKey();
            break;
            case 5:
            Console.WriteLine("Пятница");
            Console.ReadKey();
            break;
            case 6:
            Console.WriteLine("Суббота");
            Console.ReadKey();
            break;
            case 7:
            Console.WriteLine("Воскресенье");
            Console.ReadKey();
            break;
            }
        }
    }
}