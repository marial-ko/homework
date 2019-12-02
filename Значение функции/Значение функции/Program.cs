using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Значение_функции
{
    class Program
    {
        static double Function (double x)
        {
            if (-Math.PI / 2 < x & Math.PI / 2 > x)
                return Math.Tan(x);
            else if (x >= Math.PI / 2)
                return 1 / x;
            else if (x <= -Math.PI / 2)
                return -1 / x;
            else
                return 0;
        }
        static void Main()
        {
            Console.WriteLine("Введите значение ");
            var x = double.Parse(Console.ReadLine());
            Console.WriteLine(Function(x));

            Console.ReadKey();
        }
    }
}
