namespace TaskTracker;

class Program
{
    static void Main(string[] args)
    {
        TaskManager taskManager = new TaskManager();

        while (true)
        {
            Console.WriteLine("\n===== TASK TRACKER =====");
            Console.WriteLine("1. Add Task");
            Console.WriteLine("2. View All Tasks");
            Console.WriteLine("3. Mark Task as Complete");
            Console.WriteLine("4. Show Progress");
            Console.WriteLine("5. Exit");

            Console.Write("Choose an option: ");
            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    Console.Write("Enter title: ");
                    string title = Console.ReadLine();

                    Console.Write("Enter description: ");
                    string description = Console.ReadLine();

                    Console.Write("Enter start date (dd/MM/yyyy): ");
                    DateTime startDate = DateTime.ParseExact(
                        Console.ReadLine(),
                        "dd/MM/yyyy",
                        null
                    );

                    Console.Write("Enter end date (dd/MM/yyyy): ");
                    DateTime endDate = DateTime.ParseExact(
                        Console.ReadLine(),
                        "dd/MM/yyyy",
                        null
                    );

                    Task task = new Task(
                        title,
                        description,
                        startDate,
                        endDate
                    );

                    taskManager.AddTask(task);

                    Console.WriteLine("Task added successfully!");
                    break;

                case "2":
                    taskManager.ViewAllTasks();
                    break;

                case "3":
                    Console.Write("Enter task ID: ");
                    int id = int.Parse(Console.ReadLine());

                    taskManager.CompleteTask(id);

                    Console.WriteLine("Task marked as completed!");
                    break;

                case "4":
                    taskManager.ShowProgress();
                    break;

                case "5":
                    Console.WriteLine("Goodbye!");
                    return;

                default:
                    Console.WriteLine("Invalid option.");
                    break;
            }
        }
    }
}