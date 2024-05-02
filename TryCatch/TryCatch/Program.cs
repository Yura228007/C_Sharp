using System;
using static System.Console;
namespace SimpleProject
{
    class Program
    {
        static void Main(string[] args)
        {
            int number1, number2, result = 0;
            WriteLine("Введите два числа");
            try
            {
                number1 = int.Parse(ReadLine());
                number2 = int.Parse(ReadLine());
                result = number1 / number2;
                WriteLine($"Результат деления чисел: {result}");
            }
            catch (DivideByZeroException de) //конкретный
            {
                WriteLine(de.Message);
            }
            catch (Exception ex) // общий
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                Console.WriteLine("Finally wrote");
            }
            throw new ArgumentException("error with args");
        }
    }
}