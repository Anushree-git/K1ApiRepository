using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace K1Api.Models
{
    public partial class EventType
    {
        [Key]
        public int Id { get; set; }

        public string EventTypes { get; set; }

        public ICollection<Event> EventRecord { get; set; }

    }
}