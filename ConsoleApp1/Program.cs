namespace ConsoleApp1
{
    internal class Program
    {
        static void adds()
        {
            double num1, num2;
            Console.Write("Enter first number: ");
            double.TryParse(Console.ReadLine(), out num1);
            Console.Write("Enter second number: ");
            double.TryParse(Console.ReadLine(), out num2);
            Console.WriteLine("\n*********************");
            double result = num1 + num2;
            Console.WriteLine($"Result is : {result}");
            Console.WriteLine("*********************\n");
        }

        static void sub()
        {
            double num1, num2;
            Console.Write("Enter first number: ");
            double.TryParse(Console.ReadLine(), out num1);
            Console.Write("Enter second number: ");
            double.TryParse(Console.ReadLine(), out num2);
            Console.WriteLine("\n*********************");
            double result = num1 - num2;
            Console.WriteLine($"Result is : {result}");
            Console.WriteLine("*********************\n");
        }

        static void multi()
        {
            double num1, num2;
            Console.Write("Enter first number: ");
            double.TryParse(Console.ReadLine(), out num1);
            Console.Write("Enter second number: ");
            double.TryParse(Console.ReadLine(), out num2);
            Console.WriteLine("\n*********************");
            double result = num1 * num2;
            Console.WriteLine($"Result is : {result}");
            Console.WriteLine("*********************\n");
        }

        static void div()
        {
            double num1, num2;
            Console.Write("Enter first number: ");
            double.TryParse(Console.ReadLine(), out num1);
            Console.Write("Enter second number: ");
            double.TryParse(Console.ReadLine(), out num2);
            Console.WriteLine("\n*********************");
            if (num2 == 0)
            {
                Console.WriteLine("Division by zero is not allowed.");
            }
            else
            {
                double result = num1 / num2;
                Console.WriteLine($"Result is : {result}");
            }
            Console.WriteLine("*********************\n");
        }

        static void Main(string[] args)
        {
            string choice;

            do
            {
                Console.WriteLine("##########################\n");
                Console.WriteLine("Welcome to calculator C#\n");
                Console.WriteLine("##########################\n");
                Console.WriteLine("Please choose an operator below to begin\n");
                Console.WriteLine("Let's get started:\n");
                Console.WriteLine("a - to add (+)\n");
                Console.WriteLine("b - to sub (-)\n");
                Console.WriteLine("c - to multi (*)\n");
                Console.WriteLine("d - to div (/)\n");
                Console.WriteLine("e - to exit the program");
                Console.Write("The choice is: ");

                choice = Console.ReadLine().ToLower(); 
                switch (choice)
                {
                    case "a":
                        adds();
                        break;
                    case "b":
                        sub();
                        break;
                    case "c":
                        multi();
                        break;
                    case "d":
                        div();
                        break;
                    case "e":
                        Console.WriteLine("Exiting the program. Goodbye!");
                        break;
                    default:
                        Console.WriteLine("Invalid choice. Please try again.\n");
                        break;
                }

            } while (choice != "e");
        }
    }
}
