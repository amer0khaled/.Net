using System.Runtime.InteropServices.Marshalling;

namespace DelegateAssignment_2;

public class Employee
{
    public Employee(string name, double salary, double yearsOfExperience)
    {
        Name = name;
        Salary = salary;
        YearsOfExperience = yearsOfExperience;
    }
    
    public string Name { get; set; }
    public double Salary { get; set; }
    public double YearsOfExperience { get; set; }

    public static void SortEmployee(List<Employee> employees, Func<Employee, Employee, int> comparison_criteria)
    {
        for (int i = 0; i < employees.Count - 1; i++)
        {
            for (int j = i + 1; j < employees.Count; j++)
            {
                var result = comparison_criteria(employees[i], employees[j]);
                if (result == 0)
                {
                    var temp = employees[i];
                    employees[i] = employees[j];
                    employees[j] = temp;
                }
            }
        }
        
        foreach (var employee in employees)
        {
            Console.WriteLine($"Name: {employee.Name} | Salary: {employee.Salary} | Years of Experience: {employee.YearsOfExperience}");
        }
    }

    public static int CompareBasedOnYearsOfExperience(Employee employee1, Employee employee2)
    {
        if (employee1.YearsOfExperience > employee2.YearsOfExperience) return 1;
        return 0;
    }

    public static int CompareBasedOnSalary(Employee employee1, Employee employee2)
    {
        if (employee1.Salary > employee2.Salary) return 1;
        return 0;
    }

    private void PrintEmployee()
    {
        Console.WriteLine($"Name: {Name} | Salary: {Salary} | Years of Experience: {YearsOfExperience}");
    }
    
}