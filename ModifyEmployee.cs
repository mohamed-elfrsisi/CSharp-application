namespace employee_managment;

public class ModifyEmployee
{
    private List<Employee> employees;

    public ModifyEmployee(List<Employee> employees)
    {
        this.employees = employees;
    }

    public void Modify()
    {
        Console.WriteLine("Enter employee id: ");
        int id = Convert.ToInt32(Console.ReadLine());

        Employee employee = null;
        foreach (Employee emp in employees)
        {
            if (emp.Id == id)
            {
                employee = emp;
                break;
            }
        }

        if (employee == null)
        {
            Console.WriteLine("Employee not found");
            return;
        }
        
        Console.Write("Enter new name: ");
        employee.Name = Console.ReadLine();
        
        Console.Write("Enter new age: ");
        employee.Age = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter new salary: ");
        employee.Salary = Convert.ToDecimal(Console.ReadLine());
        
        Console.WriteLine("Employee modified successfully");
    }
}