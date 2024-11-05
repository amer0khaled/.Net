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

    private static void SortEmployee(List<Employee> employees, Func<Employee, Employee, int> comparison_criteria)
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
        
        PrintEmployee(employees);
    }

    public static void SortEmployeeBasedOnYearsOfExperience(List<Employee> employees)
    {
        SortEmployee(employees, CompareBasedOnYearsOfExperience);
    }
    
    public static void SortEmployeeBasedOnSalary(List<Employee> employees)
    {
        SortEmployee(employees, CompareBasedOnSalary);
    }

    private static void CalculateBonus(List<Employee> employees, Func<Employee, double> bonusCalculator)
    {
        for (int i = 0; i < employees.Count; i++)
        {
            var bonus = bonusCalculator(employees[i]);
            employees[i].Salary += bonus;
        }
        
        PrintEmployee(employees);
    }

    public static void CalculateBonusBasedOnYearsOfExperience(List<Employee> employees)
    {
        CalculateBonus(employees, GetBonusBasedOnYearsOfExperience);
    }

    private static int CompareBasedOnYearsOfExperience(Employee employee1, Employee employee2)
    {
        if (employee1.YearsOfExperience > employee2.YearsOfExperience) return 1;
        return 0;
    }

    private static int CompareBasedOnSalary(Employee employee1, Employee employee2)
    {
        if (employee1.Salary > employee2.Salary) return 1;
        return 0;
    }

    private static double GetBonusBasedOnYearsOfExperience(Employee employee)
    {
        return employee.YearsOfExperience * employee.Salary * 0.2;
    }

    private static void PrintEmployee(List<Employee> employees)
    {
        foreach (var employee in employees)
        {
            Console.WriteLine(employee);
        }
    }

    public override string ToString()
    {
        return $"Name: {Name} | Salary: {Salary} | Years of Experience: {YearsOfExperience}";
    }
    
}