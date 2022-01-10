using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace TasksManagerSys.Data
{
    [Table("tasks")]
    public class Task
    {
        public int Id { get; set; }
        public string Task_desc { get; set; }
        public DateTime Added_date { get; set; }
        public string Completed { get; set; }
        [ForeignKey("project")]
        public int Project_id { get; set; }
        public Project project{ get; set; }
        [ForeignKey("appUser")]
        public string added_by { get; set; }
        public AppUser appUser { get; set; }

    }
}
