namespace Task1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Operatorscs op = new Operatorscs();

            op.Add(5,6);
            op.Subtract(3, 2);
            op.Multiply(5,6);
            op.Divide(6,2);
            op.OddEvenFinder(5);
            op.OddEvenFinder(56);
        }
    }
}
