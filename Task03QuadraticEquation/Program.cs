using System;

/*
Author: ODarkN
Task 3: Check the Number of Solutions of a Quadratic Equation
This program asks the user to enter three values (a, b, c) representing
coefficients of a quadratic equation ax² + bx + c = 0 and determines
how many real solutions the equation has, based on the discriminant Δ.

Requirements:
- Inputs must be valid numbers.
- The program must calculate the discriminant: Δ = b² – 4ac.
- Output:
  • "Two real solutions"      if Δ > 0
  • "One real solution"       if Δ == 0
  • "No real solutions"       if Δ < 0
*/

class Task03QuadraticEquation
{
    static void Main()
    {
        Console.WriteLine("Task 3: Determine the number of real solutions of a quadratic equation based on its coefficients.");

        double a, b, c;

        // Get double 'a'
        Console.Write("Enter coefficient a: ");
        if (!double.TryParse(Console.ReadLine(), out a))
        {
            Console.WriteLine("\nThe value must be a number.");
            return;
        }

        // Get double 'b'
        Console.Write("Enter coefficient b: ");
        if (!double.TryParse(Console.ReadLine(), out b))
        {
            Console.WriteLine("\nThe value must be a number.");
            return;
        }

        // Get double 'c'
        Console.Write("Enter coefficient c: ");
        if (!double.TryParse(Console.ReadLine(), out c))
        {
            Console.WriteLine("\nThe value must be a number.");
            return;
        }

        // Calculate discriminant Δ = b² – 4ac
        double delta = b * b - 4 * a * c;

        // Display the result based on the discriminant
        Console.WriteLine("\nResult:");
        if (delta > 0)
        {
            Console.WriteLine("Two real solutions.");
        }
        else if (delta == 0)
        {
            Console.WriteLine("One real solution.");
        }
        else
        {
            Console.WriteLine("No real solutions.");
        }
    }
}
