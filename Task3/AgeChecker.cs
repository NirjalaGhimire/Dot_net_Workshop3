using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    internal class AgeChecker
    {
        public void CheckAge()
        {
            // Ask user to enter age
            Console.Write("Enter your age: ");
            int age = Convert.ToInt32(Console.ReadLine());

            // Check age using only if-else
            if (age < 13)
            {
                Console.WriteLine("You are a Child.");
            }
            else if (age >= 13 && age <= 19)
            {
                Console.WriteLine("You are a Teenager.");
            }
            else
            {
                Console.WriteLine("You are an Adult.");
            }
        }
    }
}
