using System.Collections.Generic;

namespace INFS734_Ofori_Assignment.Models
{
    public static class Repository
    {
        private static List<Task> tasks = new List<Task>();
        public static IEnumerable<Task> Tasks
        {
            get
            {
                return tasks;
            }
        }
        public static void AddTask(Task newTask)
        {
            tasks.Add(newTask);
        }
    }
}