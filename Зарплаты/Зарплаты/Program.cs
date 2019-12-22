using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Зарплаты
{
    class Program
    {
        static void Main(string[] args)
        {
            var sum = 0;
            Console.WriteLine("Введите число работников ");
            int workers = int.Parse(Console.ReadLine());

            for (var i=1; i<=workers; i++)
            {
                Console.WriteLine("Введите размер заработной платы ");
                var salary = int.Parse(Console.ReadLine());
                sum += salary;
            }

            Console.WriteLine("Общая сумма выплаченных денег: {0}", sum);


            Console.ReadKey();
        }
    }
}
