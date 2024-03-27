using System;
using System.Collections.Generic;
using System.Linq;

public class Person
{
    public string Name { get; set; }
    public int Age { get; set; }
    public string City { get; set; }
}

class Program
{
    static void Main()
    {
        // Create a list of Person objects
        List<Person> persons = new List<Person>
        {
            new Person { Name = "Alice", Age = 30, City = "New York" },
            new Person { Name = "Bob", Age = 22, City = "Los Angeles" },
            new Person { Name = "Charlie", Age = 28, City = "New York" },
            new Person { Name = "David", Age = 25, City = "Chicago" },
            new Person { Name = "Eva", Age = 35, City = "Los Angeles" }
        };

        // Use LINQ to filter people above 25 years old and living in New York
        var filteredPersons = persons
            .Where(person => person.Age > 25 && person.City == "New York")
            .ToList();

        // Use LINQ to project the filtered data into a new collection with names and ages
        var projectedData = filteredPersons
            .Select(person => new { person.Name, person.Age })
            .ToList();

        // Display the resulting collection
        Console.WriteLine("Filtered and Projected Data:");
        foreach (var person in projectedData)
        {
            Console.WriteLine($"Name: {person.Name}, Age: {person.Age}");
        }
    }
}
