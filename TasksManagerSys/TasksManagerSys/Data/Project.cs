using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace TasksManagerSys.Data
{
    [Table("projects")]
    public class Project
    {
        public int Id { get; set; }
        public string Project_name { get; set; }
        public List<Task> Tasks { get; set; }

    }
}
