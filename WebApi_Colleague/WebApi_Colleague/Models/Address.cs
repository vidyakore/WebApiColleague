using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace WebApi_Colleague.Models
{
    [Table("Address")]
    public class Address
    {

        [Key]
        public int AddressId { get; set; }
        [Required]
        public string AddLine1 { get; set; }
        public string AddLine2 { get; set; }
        [Required]
        public string City { get; set; }
        [Required]
        public string Zipcode { get; set; }

        [Required]
        public string State { get; set; }
        [Required]
        public string Country { get; set; }
        [Required]
        public DateTime Created { get; set; }

        public ICollection<Colleague> Colleagues { get; set; }
    }
}
