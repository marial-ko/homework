using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace последовательностьФибоначчи
{
    class Program
    {
        static void Main(string[] args)
        {
            var sum = 2;

            Console.WriteLine("Введите число ");
            var n = int.Parse(Console.ReadLine());

            int[] fib = new int[46];
            fib[0] = 1;
            fib[1] = 1;
            

            for (var i = 2; i<fib.Length; i++)
            {
                fib[i] = fib[i - 2] + fib[i - 1];

                if (fib[i] <= n)
                {
                    sum = sum + fib[i];
                } 
            }
            
            Console.WriteLine("Сумма всех чисел последовательности, не превышающих {1}: {0}", sum, n);

            Console.ReadKey();

        }
    }
}
