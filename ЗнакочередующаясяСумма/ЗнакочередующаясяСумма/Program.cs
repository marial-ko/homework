using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ЗнакочередующаясяСумма
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите число");
            int number = Convert.ToInt32(Console.ReadLine());
            int sum = 0;
            int sign = 1;

            while (number > 0)
            {
                sum += number % 10 * sign;
                number= number / 10;
                sign =sign * -1;
            }
            Console.WriteLine("Знакочередующаяся сумма цифр введенного числа = {0}", sum);

            Console.ReadKey();
        }
    }
}
