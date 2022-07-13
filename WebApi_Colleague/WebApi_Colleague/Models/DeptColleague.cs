using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebApi_Colleague.Models
{
    public class DeptColleague
    {
        public int id { get; set; }

        [Required]
        public int ColleagueId { get; set; }
        public Colleague Colleague { get; set; }

        [Required]
        public int DepartmentId { get; set; }
        public Department Department { get; set; }
    }
}
