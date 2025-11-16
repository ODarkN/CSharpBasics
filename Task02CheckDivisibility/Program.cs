using System;

/*
Author: ODarkN

Task 2: Check Divisibility
This program asks the user to enter two integer numbers and checks whether the
first number is divisible by the second one (a % b == 0).

Requirements: 
- The program must accept only integer inputs. 
- If the user enters non integer values, an error message must be displayed.
- If b == 0, the program must display an error (division by zero is not allowed).
- The program must output whether a is divisible by b.
*/

class Task02CheckDivisibility
{
    static void Main()
    {
        // Task welcome prompt
        Console.WriteLine("Task 2: Check whether one number is divisible by another, using integers only.");

        // Variable declaration
        int a, b;

        // Get integer 'a'
        Console.Write("Enter the first integer: ");
        if (!int.TryParse(Console.ReadLine(), out a))
        {
            Console.WriteLine("\nThe value must be an integer.");
            return;
        }

        // Get integer 'b'
        Console.Write("Enter the second integer: ");
        if (!int.TryParse(Console.ReadLine(), out b))
        {
            Console.WriteLine("\nThe value must be an integer.");
            return;
        }

        // Check division by zero
        if (b == 0)
        {
            Console.WriteLine("\nDivision by zero is not allowed.");
            return;
        }

        // Divisibility check
        Console.WriteLine("\nResult:");
        if (a % b == 0)
        {
            Console.WriteLine("The first number is divisible by the second.");
        }
        else
        {
            Console.WriteLine("The first number is NOT divisible by the second.");
        }
    }
}
