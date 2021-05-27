using System;
using System.Threading.Tasks;

namespace Factorial
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter the nth value as an integer: ");
            
            var n = Convert.ToInt32(Console.ReadLine());
            
            //loo calculatioh

            Console.WriteLine($"LOOP calculation: Factorial of {n} is {CalculateLoop(n)}");
            Console.WriteLine($"LOOP2 calculation: Factorial of {n} is {CalculateLoop(n)}");
        }

        private static int CalculateLoop(int n)
        {
            var factorial = 1;
            
            for (int i = n; i >= 1; i--)
            {
                factorial *= i;
            }

            return factorial;
        }

        private static int CalculateLoop2(int n)
        {
            var factorial = n;

            for (int i = 1; i < n; i++)
            {
                factorial *= i;
            }

            return factorial;
        }
    }
}