using System;

namespace Number3
{
    class Program
    {
        static void Main(string[] args)
        {
            int i;
            int z;
            int x = 0;
            int y = 2;
            int[] fff = new int[40];
            fff[0] = fff[1] = 1;
            for (i = 2; i < 40; i++)
            {
                fff[i] = fff[i - 1] + fff[i - 2];
                z = (fff[i] > 999 && fff[i] < 9999 ? x += 1 : y++);
            }

            Console.WriteLine();
            Console.WriteLine("Количество четырехзначных чисел: " + x + "\t Количество остальных чисел: " + y);
            Console.ReadKey();
        }
    }
}
