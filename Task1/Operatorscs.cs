using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    internal class Operatorscs
    {
        public void Add(int a, int b)
        {
            Console.WriteLine("sum: " + (a+b));
        }

        public void Subtract(int a, int b)
        {
            Console.WriteLine("Difference: " + (a - b));
        }

        public void Multiply(int a, int b)
        {
            Console.WriteLine("multiply: " + (a * b));
        }

        public void Divide(int a , int b)
        {
            if (b != 0)
                Console.WriteLine("Division: " + (a / b));
            else
                Console.WriteLine("Error : Division by zero is not allowed");
        }

        public void OddEvenFinder(int number)
        {
            string result = (number % 2 == 0) ? "Even Number" : "Odd Number";
            Console.WriteLine(result);
        }

    }
}
