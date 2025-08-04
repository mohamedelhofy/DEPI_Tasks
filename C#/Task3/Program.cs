using System;
using System.Collections.Generic;
namespace Task3
{
    //Task 
    //Create Application To Calc + , - , * , /
    //With Methods 
    //Number Odd / Even 
    //Create Method To get the Primary Number From Range 
    //Task *
    internal class Program
    {
        /// <summary>
        ///     Sumion of four integers.
        ///     can take 2, 3 or 4 parameters.
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <param name="c"></param>
        /// <param name="d"></param>
        /// <returns> integer  of sumion</returns>
        static int Add(int a, int b, int c=0, int d=0)
        {
            return a + b + c + d;
        }
        /// <summary>
        ///     subtraction of four integers.
        ///     can take 2, 3 or 4 parameters.
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <param name="c"></param>
        /// <param name="d"></param>
        /// <returns> integer  of  subtraction </returns>
        static int Subtract(int a, int b, int c = 0, int d = 0)
        {
            return a - b - c - d;
        }
        /// <summary>
        ///     multiplication of four integers.
        ///     can take 2, 3 or 4 parameters.
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <param name="c"></param>
        /// <param name="d"></param>
        /// <returns> integer  of multiplication</returns>
        static int Multiply(int a, int b, int c = 1, int d = 1)
        {
            return a * b * c * d;
        }
        /// <summary>
        ///     division of four integers.
        ///     can take 2, 3 or 4 parameters.
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <param name="c"></param>
        /// <param name="d"></param>
        /// <returns>
        /// returns double of division result.
        /// returns NaN if any divisor is zero.
        /// </returns>
        static double Divide(int a, int b, int c = 1, int d = 1)
        {
            if (b == 0 || c == 0 || d == 0)
            {
               return double.NaN; 
            }
            return (double)a / b / c / d;
        }
        /// <summary>
        ///     Determines whether the specified integer is even.
        /// </summary>
        /// <param name="number">The integer to check.</param>
        /// <returns><c>true</c> if the number is even; otherwise, <c>false</c>.</returns>
        static bool IsEven(int number)
        {
            return number % 2 == 0;
        }

        /// <summary>
        /// Determines whether the specified number is a prime number.
        /// </summary>
        /// <param name="number"></param>
        /// <returns><see langword="true"/> if the specified number is a prime number; otherwise, <see langword="false"/>.</returns>
        static bool IsPrime(int number)
        {
            if (number <= 1) return false;
            if (number == 2) return true; 
            if (number % 2 == 0) return false; 
            for (int i = 3; i * i <= number; i ++)
            {
                if (number % i == 0)
                {
                    return false;
                }
            }
            return true;
        }
        /// <summary>
        ///     Generates a linked list of prime numbers within a specified range (inclusive).
        /// </summary>
        /// <param name="start">The starting integer of the range.</param>
        /// <param name="end">The ending integer of the range.</param>
        /// <returns>
        ///     A <see cref="LinkedList{int}"/> containing all prime numbers between <paramref name="start"/> and <paramref name="end"/>.
        /// </returns>
        static LinkedList<int> PrimNum(int start, int end)
        {
            LinkedList<int> primes = new LinkedList<int>();
            for (int i = start; i <= end; i++)
            {
                if (IsPrime(i))
                {
                    primes.AddLast(i);
                }
            }
            return primes;
        }

        static void Main(string[] args)
        {
            // Example usage of the methods
            Console.WriteLine("Addition: " + Add(5, 10));
            Console.WriteLine("Subtraction: " + Subtract(10, 5));
            Console.WriteLine("Multiplication: " + Multiply(5, 10, 2));
            Console.WriteLine("Division: " + Divide(10, 2, 1, 1));
            Console.WriteLine("Is 4 even? " + IsEven(4));
            Console.WriteLine("Is 7 prime? " + IsPrime(7));
            Console.WriteLine("Prime numbers between 10 and 50:");
            LinkedList<int> primes = PrimNum(10, 50);
            foreach (var prime in primes)
            {
                Console.Write(prime + " ");
            }

        }
    }
}
