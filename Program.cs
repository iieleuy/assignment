using System;

class SimpleCalculator
{
    static void Main()
    {
        // Step 1: Get user input
        Console.Write("Enter the first number: ");
        double num1 = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter the second number: ");
        double num2 = Convert.ToDouble(Console.ReadLine());

        // Step 2: Get the operation input
        Console.Write("Choose an operation (+, -, *, /): ");
        char operation = Console.ReadKey().KeyChar;
        Console.WriteLine();

        // Step 3: Perform the calculation based on the chosen operation
        double result = 0;
        bool validOperation = true;

        switch (operation)
        {
            case '+':
                result = num1 + num2;
                break;
            case '-':
                result = num1 - num2;
                break;
            case '*':
                result = num1 * num2;
                break;
            case '/':
                if (num2 != 0)
                {
                    result = num1 / num2;
                }
                else
                {
                    Console.WriteLine("Error: Division by zero is not allowed.");
                    validOperation = false;
                }
                break;
            default:
                validOperation = false;
                Console.WriteLine("Invalid operation. Please choose +, -, *, or /.");
                break;
        }

        // Step 4: Output result in the required format
        if (validOperation)
        {
            Console.WriteLine($"Result: {num1} {operation} {num2} = {result}");
        }
    }
}
