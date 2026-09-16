namespace TaskTracker;

public class TaskManager
{
    private List<Task> tasks = new();
    private int nextId = 1;

    public void AddTask(Task task)
    {
        if (task == null)
        {
            throw new ArgumentNullException(nameof(task));
        }

        task.SetId(nextId);
        nextId++;

        tasks.Add(task);
    }
    public void ViewAllTasks()
    {
            if (tasks.Count == 0)
            {
                Console.WriteLine("NO tasks found");
                return;
            }
        foreach (var task in tasks)
        {
            Console.WriteLine($"[{task.Id}] {task.Title}");
            Console.WriteLine($"    Description: {task.Description}");
            Console.WriteLine($"    Start: {task.StartDate:dd/MM/yyyy}");
            Console.WriteLine($"    End: {task.EndDate:dd/MM/yyyy}");
            Console.WriteLine($"    Status: {(task.IsCompleted ? "Completed" : "Not Completed")}\n");

        }
    }
    public void CompleteTask(int id)
    {
        foreach (var task in tasks)
        {
            if (task.Id == id)
            {
                task.Complete();
                return;
            }
        }

    }

    public double ShowProgress()
    {
        int CompletedTasks = 0;
        foreach (var task in tasks)
        {
            if (task.IsCompleted == true)
            {
                CompletedTasks++;
            }
        }


         double progress = tasks.Count == 0 ? 0 : (double)CompletedTasks / tasks.Count * 100;
         //     [                    ]
         //     ↑                   ↑
         //     20 positions(barLength)
         int barLength = 20;
         int completedLength = (int)(progress * barLength/100);
         int remainingLength = barLength - completedLength;

         string completedBar = new string('=', completedLength);
         string remainingBar = new string('-', remainingLength);
         
         Console.WriteLine($"Progress: [{completedBar}{remainingBar}] {progress:F0}%");


         return progress;
    }
    

}