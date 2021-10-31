using System;

namespace Number2
{
    class Program
    {
        static void Main(string[] args)
        {
            int slug = Convert.ToInt32(Console.ReadLine());
            double y = 0;
            double x;
            int[] num = new int[slug];
            for (int i = 1; i < slug; i++)
            {
                x = (i % 2 == 0 ? -1 : 1) / ((double)(i * 2 - 1));
                y += x;


            }
            double ansver = y * 4;
            Console.WriteLine("Ответ: " + ansver);

        }
    }
}
