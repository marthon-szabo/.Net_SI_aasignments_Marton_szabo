using System;

namespace RandomPractice
{
    class Program
    {
        delegate int HandleCalculation(int a, int b);          
        static void Main(string[] args)
        {
            HandleCalculation subtraction = new HandleCalculation(Subtraction);
            HandleCalculation addition = new HandleCalculation(Addition);
            Console.WriteLine(subtraction(10, 10));
            Console.WriteLine(addition(10, 10));
            
        }

        static int Subtraction(int a, int b)
        {
            return a - b;
        }
        static int Addition(int a, int b)
        {
            return a + b;
        }
    }
}