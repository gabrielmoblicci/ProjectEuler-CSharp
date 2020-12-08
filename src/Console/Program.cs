using System;
using ProjectEuler.Models;

namespace console
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"Problem 1: {Problem1.SumNaturalNumbersMultipleOfGivenBelowGiven(1000, 3, 5)}");
            Console.WriteLine($"Problem 2: {Problem2.SumEvenValuedFibonacciNumbersUntil(4000000)}");
        }
    }
}
