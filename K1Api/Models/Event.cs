using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace K1Api.Models
{
    public class Event
    {
        [Key]
        public Int64 Id { get; set; }

       
        public Int64 CustomerID { get; set; }

        [ForeignKey("EventType")]
        public int EventTypeId { get; set; }

        public virtual EventType EventType { get; set; }

        public DateTime? EventDateTime { get; set; }

     

     
    }
}