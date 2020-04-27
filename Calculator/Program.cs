using System;

namespace Calculator
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Welcome To Calculator");

            Console.WriteLine("Input first number:");
            double fnum = double.Parse(Console.ReadLine());

            Console.WriteLine("Input second number:");
            double snum = double.Parse(Console.ReadLine());

            Console.WriteLine("Choose an operation: (+ , - , * , /)");
            char myapp = char.Parse(Console.ReadLine());

            calculatorMachine User = new calculatorMachine(fnum, snum, myapp);
        }
    }
}
