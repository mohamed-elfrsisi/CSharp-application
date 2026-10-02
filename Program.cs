using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Configuration;

namespace CourseMng;

class Program
{
    static void Main(string[] args)
    {
        // Read connection string from User Secrets
        var config = new ConfigurationBuilder()
            .AddUserSecrets<Program>()
            .Build();

        string connectionString =
            config.GetConnectionString("default")
            ?? throw new Exception("Connection string not found.");

        // Create objects
        GetAllCourses getAll = new GetAllCourses(connectionString);
        AddCourse add = new AddCourse(connectionString);
        UpdateCourse update = new UpdateCourse(connectionString);
        DeleteCourse delete = new DeleteCourse(connectionString);

        while (true)
        {
            Console.WriteLine("\n===== Courses Menu =====");
            Console.WriteLine("1. List");
            Console.WriteLine("2. Add");
            Console.WriteLine("3. Update");
            Console.WriteLine("4. Delete");
            Console.WriteLine("0. Exit");

            Console.Write("Choose: ");
            string choice = Console.ReadLine() ?? "";

            if (choice == "0")
                break;

            try
            {
                switch (choice)
                {
                    case "1":
                        Print(getAll.Excute());
                        break;

                    case "2":
                        Console.Write("Name: ");
                        string name = Console.ReadLine() ?? "";

                        Console.Write("Department: ");
                        string dept = Console.ReadLine() ?? "";

                        int newId = add.Execute(
                            new courses(name.Trim(), dept.Trim())
                        );

                        Console.WriteLine("Added with Id " + newId);
                        break;

                    case "3":
                        Console.Write("Id: ");
                        int uid = int.Parse(Console.ReadLine() ?? "");

                        Console.Write("New name: ");
                        string uname = Console.ReadLine() ?? "";

                        Console.Write("New department: ");
                        string udept = Console.ReadLine() ?? "";

                        bool updated = update.Execute(
                            new courses(
                                uid,
                                uname.Trim(),
                                udept.Trim()
                            )
                        );

                        Console.WriteLine(
                            updated
                                ? "Updated."
                                : "Course not found."
                        );

                        break;

                    case "4":
                        Console.Write("Id: ");
                        int did = int.Parse(Console.ReadLine() ?? "");

                        bool deleted = delete.Execute(did);

                        Console.WriteLine(
                            deleted
                                ? "Deleted."
                                : "Course not found."
                        );

                        break;

                    default:
                        Console.WriteLine("Invalid choice.");
                        break;
                }
            }
            catch (SqlException ex) when (ex.Number == 2627 || ex.Number == 2601)
            {
                Console.WriteLine("Error: course name already exists.");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
        }
    }

    static void Print(List<courses> list)
    {
        if (list.Count == 0)
        {
            Console.WriteLine("(no courses)");
            return;
        }

        Console.WriteLine(
            $"\n{"Id",-5}{"Name",-25}{"Department",-25}"
        );

        foreach (courses c in list)
        {
            Console.WriteLine(
                $"{c.ID,-5}{c.CNAME,-25}{c.CDEPT,-25}"
            );
        }
    }
}