namespace employee_managment;

public class EmployeeManager
{
    private List<Employee> employees = new List<Employee>();

    private AddEmployee addEmployee;
    private ModifyEmployee modifyEmployee;
    private DeleteEmployee deleteemployee;
    private GetAllEmployees getAllEmployee;

    public EmployeeManager()
    {
        addEmployee = new AddEmployee(employees);
        modifyEmployee = new ModifyEmployee(employees);
        deleteemployee = new DeleteEmployee(employees);
        getAllEmployee = new GetAllEmployees(employees);
    }

    public void Add()
    {
        addEmployee.Add();
    }

    public void Modify()
    {
        modifyEmployee.Modify();
    }

    public void Delete()
    {
        deleteemployee.Delete();
    }

    public void GetAll()
    {
        getAllEmployee.GetAll();
    }

}