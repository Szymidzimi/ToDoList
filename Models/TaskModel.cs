using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ToDoManager.Models
{
    public class TaskModel
    {
        public int IdTask { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int Priority { get; set; }
        public bool Status { get; set; }

    }
}
