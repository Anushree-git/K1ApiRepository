using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace K1Api.Models
{
    //[Table("FeedbackScore")]
    public class FeedbackScore
    {
        [Key]
        public int Id { get; set; }

        [ForeignKey("Feedback")]
        public Int64 FeedBackID { get; set; }
        public int? Type1 { get; set; }
        public int? Type2 { get; set; }
        public int? Type3 { get; set; }
        public int? Type4 { get; set; }
        public int? Type5 { get; set; }

        public decimal? Overall { get; set; }


        public  Feedback Feedback { get; set; }
    }
}