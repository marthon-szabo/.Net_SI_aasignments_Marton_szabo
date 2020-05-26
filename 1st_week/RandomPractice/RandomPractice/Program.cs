using System;

namespace RandomPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            Calculator calculator = new Calculator();
            Console.WriteLine(calculator.Divide(10, 10));
        }
    }
}