using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Recursion
{
    internal class Program
    {
        public static int Factorial(int number)
        {
            if (number <= 1)
            {
                return 1;
            }
            else
            {
                return number * Factorial(number - 1);
            }
        }
        public static int Fibonacci(int number)
        {
            if (number == 1)
            {
                return 1;
            }
            else if (number == 0)
            {
                return 0;
            }
            else
            {
                return Fibonacci(number-1) + Fibonacci(number-2);
            }
        }
        static void Main(string[] args)
        {
            int number = 7;
            int Fac = Factorial(number);
            int Fib = Fibonacci(number);
            Console.WriteLine(Fac);
            Console.WriteLine(Fib);
            Console.ReadLine();
        }
    }
}
