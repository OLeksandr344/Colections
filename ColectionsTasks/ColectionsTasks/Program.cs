
using ColectionsTasks;
using Task = ColectionsTasks.Task;

internal class Program
{
    private static void Main(string[] args)
    {
        
        TaskManager taskManager = new TaskManager();
        Task t1 = new Task(1,"jumping");
        Task t2 = new Task(1, "skiing");
        taskManager.Add(t1);
        taskManager.Add(t2);
        Console.WriteLine(taskManager.Count()); 
        taskManager.DisplayAllTasks();
        taskManager.RemoveAt(0);
        Console.WriteLine(taskManager.Count()); 
        taskManager.DisplayAllTasks();
        taskManager.Add(t1);
        Console.WriteLine(taskManager.Count());
        taskManager.DisplayAllTasks();
        Console.WriteLine("------------------------------");

        UserManager userManager = new UserManager();    
        User user = new User(1,"Person1");
        userManager.Add(user);
        userManager.SearchUser(1);
        userManager.DisplayAllUsers();
    }
}