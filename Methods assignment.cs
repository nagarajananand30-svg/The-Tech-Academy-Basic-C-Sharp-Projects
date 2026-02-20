using System;  // Gives access to Console and basic system functionality

namespace MethodAssignment  // Namespace to organize the program
{
    // Create a class as required
    class MathOperations
    {
        // Create a void method that takes two integers as parameters
        // This method performs a math operation on the first integer
        // and displays the second integer to the screen
        public void PerformOperation(int numberOne, int numberTwo)
        {
            // Perform a math operation on the first integer (multiply by 2)
            int result = numberOne * 2;

            // Display the result of the math operation
            Console.WriteLine("The result of the first number multiplied by 2 is: " + result);

            // Display the second integer to the screen (as required)
            Console.WriteLine("The second number is: " + numberTwo);
        }
    }

    class Program  // Main program class
    {
        static void Main(string[] args)  // Entry point of the application
        {
            // Instantiate (create an object of) the MathOperations class
            MathOperations mathObject = new MathOperations();

            // Call the method by passing in two numbers normally
            mathObject.PerformOperation(5, 10);

            Console.WriteLine(); // Blank line for readability

            // Call the method again, specifying the parameters by name
            mathObject.PerformOperation(numberOne: 7, numberTwo: 20);

            // Pause the console window so it does not close immediately
            Console.ReadLine();
        }
    }
}
