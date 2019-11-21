using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace K1Api.Models
{
    public class ServiceArea
    {
        [Key]
        public Int64 Id { get; set; }
        [MaxLength(40)]
        public string AreaName { get; set; }

        public ICollection<ServiceAllocation> ServiceAllocationRecords { get; set; }
    }
}