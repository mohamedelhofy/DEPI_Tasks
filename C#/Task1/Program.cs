namespace Task1
{
    internal class Program
    {
        static void Main(string[] args)
        {
        // Scan Two Numbers from the user  and print all opperations on them
        Start:
            Console.Write("Enter first number:");
            int num1;
            int.TryParse(Console.ReadLine(), out num1);
            Console.Write("Enter second number:");
            int num2;
            int.TryParse(Console.ReadLine(), out num2);
            Console.WriteLine($"Sum: {num1 + num2}");
            Console.WriteLine($"Difference: {num1 - num2}");
            Console.WriteLine($"Product: {num1 * num2}");
            Console.WriteLine($"Quotient: {(num2 != 0 ? num1 * 1.0 / num2 : "undefined (division by zero)")}");
            Console.WriteLine("Press any key ....");
            Console.ReadKey();
            Console.Clear();
            goto Start;
        }
    }
}
