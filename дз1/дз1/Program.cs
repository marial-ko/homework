using System;

namespace дз1
{
    class Program
    {
        static void Main(string[] args)
        {
          double x,y,z;
            x = 15;
            y = Math.Sin(x);
            z = Math.Cos(x);
            Console.WriteLine(y);
            Console.WriteLine(z);

            double a, b,c;
            a = 37;
            b = Math.Sin(a);
            c = Math.Cos(a);
            Console.WriteLine(b);
            Console.WriteLine(c);

            double m, l, n;
            m = 113;
            l = Math.Sin(m);
            n = Math.Cos(m);
            Console.WriteLine(l);
            Console.WriteLine(n);

            double p, d, f;
            Console.Write("Введите значение угла ");
            p = double.Parse(Console.ReadLine());
            d = Math.Sin(p);
            f = Math.Cos(p);
            Console.WriteLine(d);
            Console.WriteLine(f);



            Console.ReadKey();
        }
    }
}
