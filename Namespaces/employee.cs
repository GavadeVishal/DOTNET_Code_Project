namespace MyNamespace
{
    public class Employee : Person
    {
        public string JobTitle { get; set; }

        public void DisplayJobTitle()
        {
            Console.WriteLine($"Job Title: {JobTitle}");
        }
    }
}