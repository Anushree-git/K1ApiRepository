using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;


namespace K1Api.Models
{
    public class ServiceAllocation
    {
        [Key]
        public int Id { get; set; }

        //[ForeignKey("Employee")]
        public int EmpId { get; set; }

        public DateTime? ShiftDate { get; set; }

        [MaxLength(10)]
        public string shiftstartTime { get; set; }

        [MaxLength(10)]
        public string shiftendtime { get; set; }

        [ForeignKey("ServiceArea")]
        public Int64 ServiceAreaId { get; set; }
        public virtual ServiceArea ServiceArea { get; set; }
        public Employee Employee { get; set; }



    }
}