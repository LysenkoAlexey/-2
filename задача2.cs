using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            //Console.ReadKey();
            double a, b, c, d; 
            double descrim;
            a = Convert.ToDouble(Console.ReadLine());
            b = Convert.ToDouble(Console.ReadLine());
            c = Convert.ToDouble(Console.ReadLine());
            d = Convert.ToDouble(Console.ReadLine());
            
            c = c - d;
            double x1 = 0;
            double x2 = 0;
            if (a == 0 && b!=0)
            {
                x1 = -c / b;
                Console.WriteLine($"{x1}");
            }
            else if (a!=0 && b==0 && -c/a>=0)
            {
                x1 = Math.Sqrt(-c / a);
                Console.WriteLine($"{x1}");
            }
            else if (a==0 && b==0)
            {
                Console.WriteLine($"нет решений");
            }
            else
                {
                    descrim = b * b - 4 * a * c;
                    if (descrim>0)
                    {
                    x1 = ((-b + Math.Sqrt(descrim)) / (2 * a));
                    x2 = ((-b - Math.Sqrt(descrim)) / (2 * a));
                    Console.WriteLine(String.Format("x1={0:f4}; {1:f4}", x1,x2));
                    }
                    if (descrim==0)
                    {
                    x1 = -b / (2 * a);
                    Console.WriteLine($"{x1}");
                    }
                    if (descrim<0)
                    {
                    Console.WriteLine($"нет действительных корней");
                    }
                }
            Console.ReadKey();
        }
    }
}
