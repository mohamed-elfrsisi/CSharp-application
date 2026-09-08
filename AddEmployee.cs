namespace employee_managment;

public class AddEmployee
{
    private List<Employee> employees;

    public AddEmployee(List<Employee> employees)
    {
        this.employees = employees;
    }

    public void Add()
    {
        Console.Write("Please enter employee id: ");
        int id = int.Parse(Console.ReadLine());

        Console.Write("Please enter employee name: ");
        string name = Console.ReadLine();

        Console.Write("Please enter employee age: ");
        int age = int.Parse(Console.ReadLine());

        Console.Write("Please enter employee salary: ");
        decimal salary = decimal.Parse(Console.ReadLine());

        Employee employee = new Employee(id, name, age, salary);

        employees.Add(employee);

        Console.WriteLine("Employee added successfully.");
    }
}