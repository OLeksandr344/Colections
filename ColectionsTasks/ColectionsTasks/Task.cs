using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ColectionsTasks
{
    public class Task
    {
        public int TaskId { get; set; }
        public string? Description { get; set; }
        public Task(int id, string desc)
        {
            TaskId = id;
            Description = desc;
        }

    }
    public class TaskManager : List<Task>
    {
        public TaskManager()
        {

        }
        public void DisplayAllTasks()
        {
            foreach (var task in this)
            {
                Console.WriteLine($"Task ID: {task.TaskId}, Description: {task.Description}");
            }

        }
    }
    public class User
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public User(int id, string name) 
        { 
            Id = id;
            Name = name;
        }

    }
    public class UserManager : List<User>
    {
        public UserManager() { }
        public void DisplayAllUsers()
        {
            foreach (var user in this)
            {
                Console.WriteLine($"User ID: {user.Id}, Name: {user.Name}");
            }
        }
        public void SearchUser(int id)
        {
            
            foreach (var user in this)
            {
                if (id == user.Id)
                {
                    Console.WriteLine($"User ID: {user.Id}, Name: {user.Name}");
                }
                    
            }
        }
    }
}
