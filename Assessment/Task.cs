using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assessment
{
    public class Task
    {
        public string Title { get; set; }
        public TaskPriority Priority { get; set; }
        public TaskStatus Status { get; private set; }
        public TaskDuration Duration { get; set; }

        public Task(string title, TaskPriority priority, TaskDuration duration)
        {
            Title = title;
            Priority = priority;
            Status = TaskStatus.New;
            Duration = duration;
        }

        public bool UpdateStatus(TaskStatus newStatus)
        {
            if (Status == TaskStatus.Complete && newStatus == TaskStatus.New)
            {
                Console.WriteLine("Error: Cannot change status from Complete to New.");
                return false;
            }

            Status = newStatus;
            return true;
        }

        public override string ToString()
        {
            return $"Title: {Title}, Priority: {Priority}, Status: {Status}, Duration: {Duration}";
        }
    }
}
