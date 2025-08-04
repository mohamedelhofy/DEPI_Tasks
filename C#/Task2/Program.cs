namespace Task2
{
    internal class Program
    {
        static void Main(string[] args)
        {
        Start:
            // Scan Two Numbers from the user  and sacn operation
            Console.Write("Enter first number:");
            int num1;
            int.TryParse(Console.ReadLine(), out num1);
            Console.Write("Enter second number:");
            int num2;
            int.TryParse(Console.ReadLine(), out num2);
            Console.Write("Enter operation (+, -, *, /):");
            string operation = Console.ReadLine();
            // make Switch case 
            switch (operation)
            {
                case "+":
                    Console.WriteLine($"Result: {num1 + num2}");
                    break;
                case "-":
                    Console.WriteLine($"Result: {num1 - num2}");
                    break;
                case "*":
                    Console.WriteLine($"Result: {num1 * num2}");
                    break;
                case "/":
                    if (num2 != 0)
                    {
                        Console.WriteLine($"Result: {num1 / num2}");
                    }
                    else
                    {
                        Console.WriteLine("Error: Division by zero is not allowed.");
                    }
                    break;
                default:
                    Console.WriteLine("Error: Invalid operation.");
                    break;
            }
            // Ask user if they want to  another calculation
            Console.WriteLine("Do you want to another calculation? (y/n)");
            string response = Console.ReadLine()?.ToLower();
            if (response == "y")
            {
                goto Start;
            }
            else if (response == "n")
            {
                Console.WriteLine("Thank you for using the calculator!");
            }
            else
            {
                Console.WriteLine("Invalid input, Goodbye");
            }
        }
    }
}