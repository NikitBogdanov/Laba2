using System;

namespace Number8
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите 2 вещественных числа");
            double a = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());
            if (a < 0 || b < 0 || a == b)
            {
                Console.WriteLine("Ошибка");
            }
            else
            {
                double c = a < b ? Math.Pow(a, 1.0 / 2.0) : Math.Pow(b, 1.0 / 2.0);
                Console.WriteLine("Ответ: " + c);
            }
        }
    }
}
