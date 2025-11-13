using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Taask5
{
    internal class Loops
    {
        public static void SumFromOneToN()
        {
            Console.Write("Enter a number N: ");
            int N = int.Parse(Console.ReadLine());
            int sum = 0;

            for (int i = 1; i <= N; i++)
            {
                sum += i;
            }

            Console.WriteLine("Sum from 1 to " + N + " = " + sum);
        }

        // 2️⃣ Print numbers from 1 to 20 using while loop
        // Skip multiples of 4, Stop when number is 15
        public static void PrintNumbersWhileLoop()
        {
            int i = 1;

            while (i <= 20)
            {
                if (i % 4 == 0)
                {
                    i++;
                    continue; // skip multiples of 4
                }

                if (i == 15)
                    break; // stop when number is 15

                Console.WriteLine(i);
                i++;
            }
        }

        // 3️⃣ Find the sum of all elements in an array using foreach loop
        public static void SumArrayElements()
        {
            int[] numbers = { 2, 4, 6, 8, 10 };
            int sum = 0;

            foreach (int num in numbers)
            {
                sum += num;
            }

            Console.WriteLine("Sum of all elements = " + sum);
        }
    }
}
