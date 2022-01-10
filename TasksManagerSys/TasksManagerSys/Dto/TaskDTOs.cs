using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TasksManagerSys.Dto
{
    public class TaskDTOs
    {
        public int? Task_desc { get; set; }
        public int? Project_Id { get; set; }
        public DateTime? Added_date { set; get; }
        public string Completed { set; get; }
        public int? Added_by { get; set; }

    }
}
