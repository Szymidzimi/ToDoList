using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;

namespace ToDoManager.Models
{
    public class TaskModel
    {
        //private DateTime dataOfEvent;

        [DisplayName("Numer zadania")]
        public int IdTask { get; set; }
        [DisplayName("Nazwa")]
        public string Name { get; set; }
        [DisplayName("Opis")]
        public string Description { get; set; }
        [DisplayName("Data utworzenia")]
        public DateTime DataOfStart { get; set; }
        [DisplayName("Data Zdarzenia")]
        public DateTime DataOfEvent { get; set; }
        [DisplayName("Status")]
        public bool Status { get; set; }

    }
}
