using System;
using System.Collections.Generic;

namespace ConsoleApplication1
{
    class ComputeUglyNumberUsingDynamicProgramming
    {
        private static Dictionary<int, int> ComputedFibonacci = new Dictionary<int, int>();

        static void Main(string[] args)
        {
            int n = 0;
            while (true)
            {
                Console.WriteLine("Enter a number, greater than 0, to find the nth ugly number.");
                Console.WriteLine("Ugly numbers are numbers whose only prime factors are 2, 3 or 5."); 
                Console.WriteLine("The sequence 1, 2, 3, 4, 5, 6, 8, 9, 10, 12, 15, … shows the first 11 ugly numbers.");

                string input1 = Console.ReadLine();

                if (int.TryParse(input1, out n) && n > 0)
                {
                    int ugly = ComputeUglyNumber(n);
                    Console.WriteLine("Answer is {0}", ugly);
                }
                else
                {
                    Console.WriteLine("Invalid input");
                }
            }
        }

        private static int ComputeUglyNumber(int n)
        {
            int[] ugly = new int[n];
            int i2 = 0, i3 = 0, i5 = 0;
            int n2 = 2;
            int n3 = 3;
            int n5 = 5;
            int next_ugly_no = 1;

            ugly[0] = 1;

            for (int i = 1; i < n; i++)
            {
                next_ugly_no = Math.Min(n2, Math.Min(n3, n5));

                ugly[i] = next_ugly_no;

                if (next_ugly_no == n2)
                {
                    i2 = i2 + 1;
                    n2 = ugly[i2] * 2;
                }

                if (next_ugly_no == n3)
                {
                    i3 = i3 + 1;
                    n3 = ugly[i3] * 3;
                }
                if (next_ugly_no == n5)
                {
                    i5 = i5 + 1;
                    n5 = ugly[i5] * 5;
                }
            }

            return next_ugly_no;
        }
    }
}
