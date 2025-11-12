using System;

/*
Author: ODarkN
Task 1: Display Numbers
This program asks the user to enter two numbers and displays them on separate lines.
It demonstrates basic input, output, and simple data handling in C#.

Requirement: Do not use Console.WriteLine() to move to a new line.
Instead, use other methods.
*/

class Task01DisplayNumbers
{
    static void Main()
    {
        Console.WriteLine("Task 1: Display Two Numbers");

        // Get input from the user
        Console.Write("Enter the first number: ");
        double firstNumber = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter the second number: ");
        double secondNumber = Convert.ToDouble(Console.ReadLine());

        // Display results using \n instead of Console.WriteLine()
        Console.Write("\nResults:\n");
        Console.Write(firstNumber + "\n" + secondNumber);

    }
}