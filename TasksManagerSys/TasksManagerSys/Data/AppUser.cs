using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace TasksManagerSys.Data
{
    [Table("Users")]
    public class AppUser:IdentityUser
    {
        public string Fname { get; set; }
        public string Lname { get; set; }
        public DateTime Last_login { get; set; }
        public List<Task> Tasks { get; set; }
    }
}
