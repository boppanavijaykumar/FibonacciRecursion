using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fibonaccirecursion
{
    class Program
    {
        static void Main(string[] args)
        {
                int input;
                Console.WriteLine("Enter the number");
                input = int.Parse(Console.ReadLine());
                Console.WriteLine(Fibonacci(input));
                Console.ReadKey();
        }
        public static int Fibonacci(int input)
        {
                if (input == 0)
                    return 0;
                else if (input == 1)
                    return 1;
                else
                    return (Fibonacci(input - 1) + Fibonacci(input - 2));

        }
    }
}
