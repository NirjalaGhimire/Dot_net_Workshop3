using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4
{
    internal class DayOfWeek
    {
        public void PrintDay()
        {
            // Ask user to input a number
            Console.Write("Enter a number (1-7): ");
            int dayNumber = Convert.ToInt32(Console.ReadLine());

            // Use switch to print day
            switch (dayNumber)
            {
                case 1:
                    Console.WriteLine("Sunday");
                    break;
                case 2:
                    Console.WriteLine("Monday");
                    break;
                case 3:
                    Console.WriteLine("Tuesday");
                    break;
                case 4:
                    Console.WriteLine("Wednesday");
                    break;
                case 5:
                    Console.WriteLine("Thursday");
                    break;
                case 6:
                    Console.WriteLine("Friday");
                    break;
                case 7:
                    Console.WriteLine("Saturday");
                    break;
                default:
                    Console.WriteLine("Invalid day number");
                    break;
            }
        }
    }
}
