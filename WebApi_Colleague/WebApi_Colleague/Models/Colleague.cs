using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebApi_Colleague.Models
{
    public class Colleague
    {
        public int ColleagueId { get; set; }

        [Display(Name = "Name")]
        [Required]
        public string ColleagueName { get; set; }

        [Required]
        public DateTime created { get; set; }

        [Display(Name = "Address Id")]
        [Required]
        public int AddressId { get; set; }
        public Address Address { get; set; }

        public ICollection<DeptColleague> DeptColleague { get; set; }

        //changed
        public List<Colleague> _colleagues;
    }
}
