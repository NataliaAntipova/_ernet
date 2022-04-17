/*5 задание*/
/*int number = Int32.Parse(Console.ReadLine());
ChangeDigits(number);
static void ChangeDigits(int number)
{
    int a = number / 10; //Десятки
    int b = number % 10; //Единицы
    Console.WriteLine(b * 10 + a);
}*/

/*6 задание*/
/*Console.WriteLine("Введите два двузначных числа: ");
int first = int.Parse(Console.ReadLine());
int second = int.Parse(Console.ReadLine());
Console.WriteLine("Побитовая сумма чисел " + BitwiseSum(first, second));
static int BitwiseSum(int first, int second)
{
    int a = first / 10; //Десятки первого числа
    int b = first % 10; //Единицы первого числа

    int c = second / 10; //Десятки второго числа
    int d = second % 10; //Единицы второго числа
    int result = (a + c) * 10 + (b + d) % 10;
    return result
}*/

/* 7 задание*/
/*int positive = 0;
int negative = 0;

PosNegSeq(ref positive, ref negative);

static void PosNegSeq(ref int positive, ref int negative)
{
    int number = 0;
    do
    {
        number = int.Parse(Console.ReadLine());
        if (number > 0)
        {
            positive++;
        }
        else if (number < 0)
        {
            negative++;
        }
    } while (number != 0);
    Console.WriteLine($"Положительные: {positive}");
    Console.WriteLine($"Отрицательные: {negative}");
}*/
