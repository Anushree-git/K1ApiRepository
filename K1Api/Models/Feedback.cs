using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace K1Api.Models
{
    [Table("Feedback")]
    public class Feedback
    {
        [Key]
        public Int64 Id { get; set; }

        [ForeignKey("Customer")]
        public Int64 CustomerID { get; set; }

        public DateTime? VisitedDate { get; set; }
        public int? StaffID { get; set; }
        [MaxLength(40)]
        public string ServiceAreas { get; set; }
        [MaxLength]
        public string FeedbackComment { get; set; }
        [MaxLength]
        public string ManagerComment { get; set; }
        public bool IsReviewd { get; set; }
        public int? ReviewedBy { get; set; }
        public DateTime? ReviewDate { get; set; }


        // reference navigation property represents a relationship to another entity.
        public Customer Customer { get; set; }

        public  ICollection<FeedbackScore> FeedbackScoreRecord { get; set; }
    }
}