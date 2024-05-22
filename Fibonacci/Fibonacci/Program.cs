using System;
using System.Collections.Generic;

public class FibonacciGenerator
{
    public IEnumerable<int> GenerateFibonacci(int count)
    {
        int prev = 0;
        int current = 1;

        for (int i = 0; i < count; i++)
        {
            yield return current;

            int temp = current;
            current = prev + current;
            prev = temp;
        }
    }
}

namespace Fibonacci
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int userNumber;
            Console.Write("Enter a number: ");
            bool isValidInput = Int32.TryParse(Console.ReadLine(), out userNumber);

            while (!isValidInput) 
            {
                Console.WriteLine("The entered data is incorrect. Try again");
                Console.Write("Enter a number: ");
                isValidInput = Int32.TryParse(Console.ReadLine(), out userNumber);
            }

            FibonacciGenerator generator = new FibonacciGenerator();

            foreach (int number in generator.GenerateFibonacci(userNumber))
            {
                Console.WriteLine(number);
            }
            Console.ReadKey();
        }
    }
}
