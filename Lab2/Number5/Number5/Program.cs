using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Number5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите натуральное число N: ");
            int N = Convert.ToInt32(Console.ReadLine());
            bool Find = false;
            var x = new List<int>();
            var y = new List<int>();
            var z = new List<int>();
            int[] Numbers = new int[N];
            for (int i = 1; i < N; i++)
            {
                for (int j = 1; j < N; j++)
                {
                    for (int k = 1; k < N; k++)
                    {
                        double ansver = Math.Pow(i, 3) + Math.Pow(j, 3) + Math.Pow(k, 3);
                        if (ansver == N)
                        {
                            Find = true;
                            x.Add(i);
                            y.Add(j);
                            z.Add(k);
                            for (int l = 0; l < x.Count; l++)
                            {
                                Console.WriteLine("Ответ: N = {0}^3 + {1}^3 + {2}^3", x[l], y[l], z[l]);
                            }
                        }


                    }
                }

            }
            if (Find == false)
            {
                Console.WriteLine("Ошибка");
            }
        }
    }
}
