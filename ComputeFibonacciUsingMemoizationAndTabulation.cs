using System;
using System.Collections.Generic;

namespace ConsoleApplication1
{
    class ComputeFibonacciUsingMemoizationAndTabulation
    {
        private static Dictionary<int, int> ComputedFibonacci = new Dictionary<int, int>();

        static void Main(string[] args)
        {
            int n = 0;
            while (true)
            {
                Console.WriteLine("Enter a number, greater than 0, to find the nth fibonacci number");
                string input1 = Console.ReadLine();

                if (int.TryParse(input1, out n) && n > 0)
                {
                    int m = ComputeFibonacciUsingMemoization(n);

                    if (!ComputedFibonacci.ContainsKey(n))
                    {
                        ComputedFibonacci.Add(n, m);
                    }

                    Console.WriteLine("Answer using Memoization technique is {0}", m);


                    int t = ComputeFibonacciUsingTabulation(n);
                    Console.WriteLine("Answer using Tabulation technique is {0}", m);
                }
                else
                {
                    Console.WriteLine("Invalid input");
                }
            }
        }

        private static int ComputeFibonacciUsingTabulation(int n)
        {
            int[] f = new int[n + 1];
            f[0] = 1;
            f[1] = 1;
            for (int i = 2; i <= n; i++)
            {
                f[i] = f[i - 2] + f[i - 1];
            }

            return f[n];
        }

        private static int ComputeFibonacciUsingMemoization(int n)
        {
            if (n <= 2)
            {
                return 1;
            }
            else 
            {
                int value = 0;
                if(ComputedFibonacci.ContainsKey(n) && ComputedFibonacci.TryGetValue(n, out value))
                {
                    return value;
                }
                else
                {
                    return ComputeFibonacciUsingMemoization(n - 2) + ComputeFibonacciUsingMemoization(n - 1);
                }
            }            
        }
    }
}
