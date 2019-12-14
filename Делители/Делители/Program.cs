using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Делители
{
    class Program
    {
        static void Main(string[] args)
        {
            var sum = 0;
            Console.WriteLine("Введите a");
            var a = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите b");
            var b = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите k (2<=k<=10)");
            var k = int.Parse(Console.ReadLine());

            for (var i = a; i <= b; i++)
                for (var j = 1; j <= i; j++)
                {
                    if (i % j == 0)
                        sum = sum + j;

                    if (sum % k == 0)
                        Console.WriteLine("Число, сумма делителей которого кратна {1}: {0}", i, k);
                }
                
                Console.ReadKey();
        }
    }
}
