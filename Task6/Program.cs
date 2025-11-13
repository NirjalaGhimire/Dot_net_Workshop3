using System.Threading.Tasks;

namespace Task6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 1️⃣ Try-Catch-Finally for number conversion
            ClassException.ConvertToInteger();

            // 2️⃣ Password validation with throw
            ClassException.CheckPassword();
        }
    }
}
