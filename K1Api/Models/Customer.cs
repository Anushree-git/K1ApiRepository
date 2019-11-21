using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace K1Api.Models
{
    public class Customer
    {
        //scalar property
        [Key]
        public Int64 Id { get; set; }
        [MaxLength(80)]
        public string FName { get; set; }
        [MaxLength(80)]
        public string LName { get; set; }
        [MaxLength(120)]
        public string EmailId { get; set; }
        [MaxLength(12)]
        public string PhoneNo { get; set; }

        //Collection navigation property represents a relationship to another entity.
        public ICollection<Feedback> Feedbacks { get; set; }

       
    }

}