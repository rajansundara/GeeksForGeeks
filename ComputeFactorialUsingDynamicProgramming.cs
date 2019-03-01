using System;
using System.Collections.Generic;

namespace ConsoleApplication1
{
    class ComputeFactorialUsingDynamicProgramming
    {
        private static Dictionary<int, long> ComputedFactorial = new Dictionary<int, long>();

        static void Main(string[] args)
        {
            int n = 0;
            while (true)
            {
                Console.WriteLine("Enter a number, greater than 0");
                string input1 = Console.ReadLine();

                if (int.TryParse(input1, out n) && n >= 0)
                {
                    long ans = ComputeFactorial(n);
                    if (!ComputedFactorial.ContainsKey(n))
                    {
                        ComputedFactorial.Add(n, ans);
                    }

                    Console.WriteLine("Factorial = {0}", ans);
                }
                else
                {
                    Console.WriteLine("Invalid input");
                }
            }
        }

        private static long ComputeFactorial(int n)
        {
            if (n <= 1)
            {
                return 1;
            }
            else
            {
                long value = 0;
                if (ComputedFactorial.ContainsKey(n) && ComputedFactorial.TryGetValue(n, out value))
                {
                    return value;
                }
                else
                {
                    long tmp = ComputeFactorial(n - 1);
                    if (!ComputedFactorial.ContainsKey(n - 1))
                    {
                        ComputedFactorial.Add(n - 1, tmp);
                    }

                    return n * tmp;
                }
            }            
        }
    }
}
