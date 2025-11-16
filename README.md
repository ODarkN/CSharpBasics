# CSharpBasics Educational Tasks

Author: ODarkN

*This repository contains simple C# programs created for educational purposes.  
Each task is placed in its own folder, with fully commented code, input requirements, and expected output.*

### Project Structure

```csharp
CSharpBasics/
│
├─ Task01DisplayNumbers/ 
├─ Task02CheckDivisibility/ 
├─ Task03QuadraticEquation/
```

### Tasks Overview

**Task 1: Display Two Numbers**
- **Description:** *This program asks the user to enter two numbers and displays them on separate lines.
It demonstrates basic input, output, and simple data handling in C#.*

- **Requirements:**  
*- Do not use Console.WriteLine() to move to a new line. Instead, use other methods.*

**Task 2: Check whether one number is divisible by another, using integers only.**
- **Description:** *This program asks the user to enter two integer numbers and checks whether the first number is divisible by the second one (a % b == 0).*

- **Requirements:**  
*- The program must accept only integer inputs.*  
*- If the user enters non integer values, an error message must be displayed.*  
*- If b == 0, the program must display an error (division by zero is not allowed). The program must output whether a is divisible by b.*  

**Task 3: Determine the number of real solutions of a quadratic equation based on its coefficients.**
- **Description:** *This program asks the user to enter three values (a, b, c) representing coefficients of a quadratic equation ax² + bx + c = 0 and determines
how many real solutions the equation has, based on the discriminant Δ.*

- **Requirements:**  
*- Inputs must be valid numbers.*  
*- The program must calculate the discriminant: Δ = b² – 4ac.*  
*- Output: "Two real solutions" if Δ > 0, "One real solution" if Δ == 0, "No real solutions" if Δ < 0.*  

### How to Run
*- Open the folder of the desired task in Visual Studio or any C# IDE.*  
*- Build and run the project.*  
*- Follow on screen instructions to provide input.*  

### Notes
*- All tasks are designed for learning and demonstration purposes.*  
*- The code is commented to explain each step clearly.*  