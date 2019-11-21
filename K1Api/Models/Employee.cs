using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace K1Api.Models
{
    public partial class Employee
    {
        [Key]
        public int ID { get; set; }
        [MaxLength(80)]
        public string FirstName { get; set; }
        [MaxLength(80)]
        public string LastName { get; set; }
        [MaxLength(20)]
        public string Job { get; set; }

        public ICollection<ServiceAllocation> ServiceAllocationRecord { get; set; }
    }
}
