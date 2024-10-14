using System;

class Program
{
    static void Main()
    {
        int num1, num2, sum;

        // Ask the user for input
        Console.Write("Enter first number: ");
        num1 = Convert.ToInt32(Console.ReadLine());
        
        Console.Write("Enter second number: ");
        num2 = Convert.ToInt32(Console.ReadLine());

        // Calculate the sum
        sum = num1 + num2;

        // Print the result
        Console.WriteLine("The sum of {0} and {1} is {2}", num1, num2, sum);
    }
}
