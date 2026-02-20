using System;  // Provides access to Console and other system functionality

namespace InterfaceAssignment  // Namespace to organize related classes
{
    // Create an interface called IQuittable
    // An interface defines behavior that a class must implement
    public interface IQuittable
    {
        // Define a void method called Quit()
        void Quit();
    }

    // Employee class implements (inherits from) IQuittable interface
    public class Employee : IQuittable
    {
        // Auto-implemented properties
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        // Implement the Quit() method from the IQuittable interface
        // This method must exist because Employee implements IQuittable
        public void Quit()
        {
            // Display message when Quit() is called
            Console.WriteLine(FirstName + " has resigned from the company.");
        }
    }

    class Program  // Main program class
    {
        static void Main(string[] args)  // Entry point of the console application
        {
            // Instantiate an Employee object
            Employee employee = new Employee()
            {
                Id = 101,
                FirstName = "Ruchi",
                LastName = "Sharma"
            };

            // Use polymorphism:
            // Create an object of type IQuittable
            // Even though it's declared as IQuittable,
            // it is actually an Employee object underneath
            IQuittable quittableEmployee = employee;

            // Call the Quit() method using the interface reference
            quittableEmployee.Quit();

            // Pause console so it doesn't close immediately
            Console.ReadLine();
        }
    }
}
