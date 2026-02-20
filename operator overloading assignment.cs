using System;  // Provides access to Console and base system functionality

namespace EmployeeComparison  // Namespace to organize the code
{
    // Create the Employee class
    public class Employee
    {
        // Auto-implemented properties for Id, FirstName, and LastName
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        // Overload the == operator to compare two Employee objects
        // This checks whether the Id values are equal
        public static bool operator ==(Employee emp1, Employee emp2)
        {
            // If both objects are null, return true
            if (ReferenceEquals(emp1, emp2))
                return true;

            // If one is null and the other is not, return false
            if (emp1 is null || emp2 is null)
                return false;

            // Compare Id properties
            return emp1.Id == emp2.Id;
        }

        // Over
