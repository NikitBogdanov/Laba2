using System;

namespace Number7
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i <= x; i++)
            {
                if (x % i == 0)
                {
                    if (i % 2 == 0)
                    {
                        Console.WriteLine("Ответ: " + i);
                        
                    }
                   
                }
            }
        }
    }
}
