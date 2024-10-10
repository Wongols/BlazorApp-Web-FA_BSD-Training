using System.Collections.Generic;
using BlazorApp_FA_BSD_Training.Data;
using BlazorApp_FA_BSD_Training.Models;
namespace BlazorApp_FA_BSD_Training.Services




{
    public class ToDoService
    {

        private List<ToDoItem> tasks = new List<ToDoItem>();

        public IEnumerable<ToDoItem> GetTasks() => tasks;

        public void AddTask(ToDoItem task) => tasks.Add(task);

        public void RemoveTask(ToDoItem task) => tasks.Remove(task);
    }
}
