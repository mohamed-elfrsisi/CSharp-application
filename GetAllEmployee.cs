namespace employee_managment;

public class GetAllEmployees
{
    private List<Employee> employees;

    public GetAllEmployees(List<Employee> employees)
    {
        this.employees = employees;
    }

    public void GetAll()
    {
        if (employees.Count == 0)
        {
            Console.WriteLine("NO employee found");
            return;
        }

        foreach (Employee employee in employees)
        {
            Console.WriteLine("===========================");
            Console.WriteLine($"Id {employee.Id}");
            Console.WriteLine($"name {employee.Name}");
            Console.WriteLine($"age {employee.Age}");
            Console.WriteLine($"salary {employee.Salary}");
        }
    }
    
}