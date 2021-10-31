using System;

namespace Number1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите a, b, c");
            double a = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());
            double c = double.Parse(Console.ReadLine());
            double D = Math.Pow(b, 2) - 4 * a * c;
            if (D < 0)
            {
                Console.WriteLine("Уравнение не имеет корней!");
            }
            else if (D > 0)
            {


                double x1 = (-b + Math.Sqrt(D)) / a * 2;
                double x2 = (-b - Math.Sqrt(D)) / a * 2;
                Console.WriteLine("Ответ: " + x1, "/t Ответ: " + x2);



            }
            else
            {
                double x = -b / a * 2;
                Console.WriteLine("Ответ: " + x);
            }
        }
    }
}
