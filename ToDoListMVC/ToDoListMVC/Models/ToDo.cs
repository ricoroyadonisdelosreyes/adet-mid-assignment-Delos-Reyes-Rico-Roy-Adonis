using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ToDoListMVC.Models
{
    public class ToDo
    {
        public int Id { get; set; }

        public string TodoTask { get; set; }

        [Display(Name = "Date Created")]
        [DataType(DataType.Date)]
        public DateTime DateCreated { get; set; }

        [Display(Name = "Date Started")]
        [DataType(DataType.Date)]
        public DateTime DateStarted { get; set; }

        [Display(Name = "Date Finished")]
        [DataType(DataType.Date)]
        public DateTime DateFinish { get; set; }

        public int TotalHours { get; set; }
        public bool Done { get; set; }

    }
}
