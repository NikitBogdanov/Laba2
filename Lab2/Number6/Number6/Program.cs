using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Number6
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = int.Parse(Console.ReadLine());
            int[] number = { 11, 12, 13, 14 };
            if (number.Contains(x))
            {
                Console.WriteLine("\t" + x + " лет");
            }
            else if (x % 10 == 1)
            {
                Console.WriteLine("\t" + x + "год");
            }
            
            else if (x % 10 == 2 || x % 10 == 3 || x % 10 == 4)
            {
                Console.WriteLine("\t" + x + " Года");
            }
            else
            {
                Console.WriteLine("\t" + x + " Лет");
            }
            
        }
    }
}
