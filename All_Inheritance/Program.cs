//Single Inheritance

/*
using System;

public class Person
{
    public string Name { get; set; }
    public int Age { get; set; }

    public void DisplayInfo()
    {
        Console.WriteLine($"Name: {Name}, Age: {Age}");
    }
}

public class Student : Person
{
    public int StudentId { get; set; }

    public void Study()
    {
        Console.WriteLine($"{Name} is studying.");
    }
}

public class Program
{
    public static void Main()
    {
        Student student = new Student { Name = "Vishal", Age = 20, StudentId = 12345 };
        student.DisplayInfo();  
        student.Study();        
    }
}
*/

//Multiple Inheritance


using System;

public interface ITeach
{
    void Teach();
}

public interface IStudy
{
    void Study();
}

public class TeachingAssistant : ITeach, IStudy
{
    public string Name { get; set; }

    public void Teach()
    {
        Console.WriteLine($"{Name} is teaching.");
    }

    public void Study()
    {
        Console.WriteLine($"{Name} is studying.");
    }
}

public class Program
{
    public static void Main()
    {
        TeachingAssistant ta = new TeachingAssistant { Name = "Vishal" };
        ta.Teach();   
        ta.Study();   
    }
}


//Multilevel Inheritance

/*
using System;

public class Person
{
    public string Name { get; set; }
    public int Age { get; set; }

    public void DisplayInfo()
    {
        Console.WriteLine($"Name: {Name}, Age: {Age}");
    }
}

public class Student : Person
{
    public int StudentId { get; set; }

    public void Study()
    {
        Console.WriteLine($"{Name} is studying.");
    }
}

public class GraduateStudent : Student
{
    public string ResearchTopic { get; set; }

    public void WriteThesis()
    {
        Console.WriteLine($"{Name} is writing a thesis on {ResearchTopic}.");
    }
}

public class Program
{
    public static void Main()
    {
        GraduateStudent gradStudent = new GraduateStudent
        {
            Name = "Vishal",
            Age = 25,
            StudentId = 54321,
            ResearchTopic = "Machine Learning"
        };
        gradStudent.DisplayInfo();    
        gradStudent.Study();          
        gradStudent.WriteThesis();    
    }
}
*/

//Hierarchical Inheritance

/*
using System;

public class Person
{
    public string Name { get; set; }
    public int Age { get; set; }

    public void DisplayInfo()
    {
        Console.WriteLine($"Name: {Name}, Age: {Age}");
    }
}

public class Student : Person
{
    public int StudentId { get; set; }

    public void Study()
    {
        Console.WriteLine($"{Name} is studying.");
    }
}

public class Teacher : Person
{
    public string Subject { get; set; }

    public void Teach()
    {
        Console.WriteLine($"{Name} is teaching {Subject}.");
    }
}

public class Program
{
    public static void Main()
    {
        Student student = new Student { Name = "Vishal", Age = 20, StudentId = 12345 };
        student.DisplayInfo();  
        student.Study();        

        Teacher teacher = new Teacher { Name = "Dr.Sangule", Age = 45, Subject = "Physics" };
        teacher.DisplayInfo();  
        teacher.Teach();        
    }
}
*/

//Hybrid Inheritance

/*
using System;

public interface IResearch
{
    void ConductResearch();
}

public class Person
{
    public string Name { get; set; }
    public int Age { get; set; }

    public void DisplayInfo()
    {
        Console.WriteLine($"Name: {Name}, Age: {Age}");
    }
}

public class Student : Person
{
    public int StudentId { get; set; }

    public void Study()
    {
        Console.WriteLine($"{Name} is studying.");
    }
}

public class GraduateStudent : Student, IResearch
{
    public string ResearchTopic { get; set; }

    public void WriteThesis()
    {
        Console.WriteLine($"{Name} is writing a thesis on {ResearchTopic}.");
    }

    public void ConductResearch()
    {
        Console.WriteLine($"{Name} is conducting research on {ResearchTopic}.");
    }
}

public class Program
{
    public static void Main()
    {
        GraduateStudent gradStudent = new GraduateStudent
        {
            Name = "Emma",
            Age = 25,
            StudentId = 54321,
            ResearchTopic = "Machine Learning"
        };
        gradStudent.DisplayInfo();        
        gradStudent.Study();              
        gradStudent.WriteThesis();        
        gradStudent.ConductResearch();    
    }
}
*/
