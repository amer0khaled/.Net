
using DelegateAssignment_2;

internal class Program
{
    public static void Main(string[] args)
    {
        // List of employess
        var employees = new List<Employee>
        {
            new Employee("Amer khaled", 2000, 1),
            new Employee("mohab ahmed", 3000, 1.5),
            new Employee("yousif walid", 4000, 2.5),
            new Employee("ahmed said", 4200, 3.5),
            new Employee("abutalib", 2700, 2.4),
            new Employee("ziad", 3300, 2)
        };

        // sort employee based on salary DESC order
        Console.WriteLine("sorted list based on salary in DESC order:");
        Employee.SortEmployee(employees, Employee.CompareBasedOnSalary);
        
        Console.WriteLine();
        
        // sort employee based on years of experience DESC order
        Console.WriteLine("sorted list based on years of experience in DESC order:");
        Employee.SortEmployee(employees, Employee.CompareBasedOnYearsOfExperience);
        
        Console.WriteLine();
        
        // calculate bonus based on experience
        Console.WriteLine("calculate bonus based in years of experience:");
        Employee.CalculateBonus(employees, Employee.GetBonusBasedOnYearsOfExperience);
        
    }
}