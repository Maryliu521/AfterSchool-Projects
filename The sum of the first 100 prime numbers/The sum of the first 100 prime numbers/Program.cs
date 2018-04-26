using System;

namespace The_sum_of_the_first_100_prime_numbers
{
    class Program
    {
        static void Main(string[] args)
        {  
            // Prime numbers are the natural numbers that are greater than one but can't be multiply by two smaller numbers. 
            Console.WriteLine("\nSum of the first 100 prime numbers: ");
            long sum = 0;
            int ctr = 0;
            int n = 2;
            while (ctr < 100)
            {
                if (isPrime(n))
                {
                    sum += n;
                    ctr++;
                }
                n++;
            }

            Console.WriteLine(sum.ToString());
            Console.Read();

        }
        public static bool isPrime(int n)
        {
            //Math.Floor() -- returns the largest integer less than or equal to a given 
            //Math.Sqrt() --  returns the square root of a number
            int x = (int)Math.Floor(Math.Sqrt(n));

            if (n == 1) return false;
            if (n == 2) return true;

            for (int i = 2; i <= x; ++i)
            {
                if (n % i == 0) return false;
            }

            return true;
        }
    }
    }

