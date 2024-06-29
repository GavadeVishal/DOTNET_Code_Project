using System;
using MyNamespace; 

class Program
{
    static void Main()
    {
       
        Person person = new Person
        {
            Name = "Alice",
            Age = 30
        };
        person.DisplayInfo();

     
        Employee employee = new Employee
        {
            Name = "Bob",
            Age = 35,
            JobTitle = "Software Developer"
        };
        employee.DisplayInfo();
        employee.DisplayJobTitle();
    }
}