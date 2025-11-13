using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task6
{
    internal class ClassException
    {
        public static void ConvertToInteger()
        {
            try
            {
                Console.Write("Enter a number: ");
                string input = Console.ReadLine();
                int number = Convert.ToInt32(input);
                Console.WriteLine("You entered: " + number);
            }
            catch (FormatException)
            {
                Console.WriteLine("Invalid number format");
            }
            finally
            {
                Console.WriteLine("Program Executed");
            }
        }

        // 2️⃣ Password validation using throw
        public static void CheckPassword()
        {
            try
            {
                Console.Write("Enter password: ");
                string password = Console.ReadLine();

                if (password.Length < 6)
                {
                    throw new Exception("Password must be at least 6 characters.");
                }

                Console.WriteLine("Password satisfied the requirement");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
