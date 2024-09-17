using System.Collections;
using System.Collections.Generic;

namespace TaskApi.Entities
{
    public class Task
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public bool Completed { get; set; }
        public int UserId { get; set; }
        public User User { get; set; }
        public ICollection<SubTask> SubTasks { get; set; }
    }
}