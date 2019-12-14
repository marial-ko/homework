using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ЧетныеЧисла
{
    class Program
    {
        static void Main(string[] args)
        {
            var sum = 0;
            Console.WriteLine("Введите количество чисел в последовательности \n(последний член последовательности должен быть равен 0)");
            var count = int.Parse(Console.ReadLine());

            for (var i=0; i<count; i++)
            {
                Console.WriteLine("Введите член последовательности ");
                var element = int.Parse(Console.ReadLine());
                if (element % 2 == 0)
                    sum++;
                else if (element==0)
                            sum = sum;
                else
                    sum = sum;
            }
            Console.WriteLine("Количество четных чисел последовательности: {0}", sum);

            Console.ReadKey();
        }
    }
}
