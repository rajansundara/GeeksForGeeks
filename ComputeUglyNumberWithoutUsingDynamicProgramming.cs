using System;
using System.Collections.Generic;

namespace ConsoleApplication1
{
    class ComputeUglyNumberWithoutUsingDynamicProgramming
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
            int a = 1;
            int count = 1;
            while (count != n)
            {
                a++;
                if (ComputePrimeFactors(a))
                {
                    count++;
                }
            }

            return a;
        }

        private static bool ComputePrimeFactors(int a)
        {
            bool ugly = true;
            for (int i = 2; i <= a; i++)
            {
                if (a % i == 0)
                {
                    bool prime = true;
                    for (int j = 2; j < i; j++)
                    {
                        if (i % j == 0)
                        {
                            prime = false;
                            break;
                        }
                    }

                    if (prime && i != 2 && i != 3 && i != 5)
                    {
                        ugly = false;
                        break;
                    }
                }
            }

            return ugly;
        }        
    }
}
