namespace employee_managment;

class Program
{
    static void Main(string[] args)
    {
        EmployeeManager manager = new EmployeeManager();
        while (true)
        {
            Console.WriteLine("===== Employee Management System =====");
            Console.WriteLine("Please enter 1 to add employee:");
            Console.WriteLine("Please enter 2 to modify employee:");
            Console.WriteLine("Please enter 3 to delete employee:");
            Console.WriteLine("Please enter 4 to get all employees:");
            
            
            Console.Write("choice: ");
            int choice = Convert.ToInt32(Console.ReadLine());

            if (choice == 1)
            {
                manager.Add();
            }
            else if (choice == 2)
            {
                manager.Modify();
            }
            else if (choice == 3)
            {
                manager.Delete();
            }
            else if (choice == 4)
            {
                manager.GetAll();
            }
            else
            {
                Console.WriteLine("invalid choice");
            }
        }
    }
}