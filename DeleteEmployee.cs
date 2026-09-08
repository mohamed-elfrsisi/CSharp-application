namespace employee_managment;

public class DeleteEmployee
{
    private List<Employee> employees;

    public DeleteEmployee(List<Employee> employees)
    {
        this.employees = employees;
    }

    public void Delete()
    {
        Console.WriteLine("Please enter employee id: ");
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
        employees.Remove(employee);
        Console.WriteLine($"Employee with id {employee.Id} deleted successfully");
    }
}