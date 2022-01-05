using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace H.W._23
{
    
    class Program
    {
        static double Factorial(int a)
        {
            if (a % 1 == 0)
            {
                if (a == 0) return 1;

                if (a > 0)
                {
                    int _ = 1;

                    for (int i = 1; i <= a; i++)
                    {
                        _ *= i;
                        Console.WriteLine($"{ _}");
                        Thread.Sleep(100);
                    }
                    return _;
                }
            }
            return double.NaN;
        }
        static void Main(string[] args)
        {
            double d = MethodAsync(5).Result;

            Console.WriteLine("Main End");
            Console.ReadKey();

        }
        static async Task<double> MethodAsync(int n)
        {
            Console.WriteLine("MethodAsync Начал работу");
            double result = await Task.Run(() => Factorial(n));
            Console.WriteLine("MethodAsync Закончил работу");
            return result;
        }
    }
}
