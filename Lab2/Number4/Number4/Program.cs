using System;

namespace Number4
{
    class Program
    {
        public static double factorial(int i)
        {
            return i != 0 ? factorial(i - 1) * i : 1;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Введите: ");
            double q = double.Parse(Console.ReadLine());


            if (q > 0)
            {
                double x = double.Parse(Console.ReadLine());
                double z = 1;
                double ansver = 1;
                z = (Math.Pow(x, 2) / factorial(2));
                int i = 1;
                do
                {
                    ansver = i % 2 == 0 ? ansver + z : ansver - z;
                    i++;
                    z = (Math.Pow(x, (2 * i)) / factorial(2 * i));

                } while (z >= q);
                Console.WriteLine(ansver);








            }
            else
            {
                Console.WriteLine("Ошибка: q не может быть отрицательным!");
            }
        }
    }
}
