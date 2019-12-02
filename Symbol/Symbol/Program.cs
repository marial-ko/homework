using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Symbol
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите символ: ");
            int symbol = Console.Read();
            Console.WriteLine("Код символа: 0x" + Convert.ToString(symbol, 16));
            Console.WriteLine("Следующий символ из таблицы: {0}", (char)(++symbol));

            Console.ReadKey();
        }
    }
}
