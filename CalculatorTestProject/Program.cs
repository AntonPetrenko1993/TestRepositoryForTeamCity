using System;

namespace CalculatorTestProject
{
    class Program
    {
        static void Main(string[] args)
        {
            Calculator calculator = new Calculator();
            Console.WriteLine(calculator.Sum(2,2));
        }
    }
}
