using System.Data.Entity.ModelConfiguration;
using System.ComponentModel.DataAnnotations;
using K1Api.Models;
using System;
using System.Collections.Generic;

namespace K1Api.Context.Mapping
{
    public class FeedbackScoreMap : EntityTypeConfiguration<FeedbackScore>
    {
        public FeedbackScoreMap()
        {
            this.HasKey(t => t.Id);

            this.Property(t => t.FeedBackID);
            this.Property(t => t.Type1);
            this.Property(t => t.Type2);
            this.Property(t => t.Type3);
            this.Property(t => t.Type4);
            this.Property(t => t.Type5);
            this.Property(t => t.Overall);

            this.ToTable("Feedbackscore");
            this.Property(t => t.Id).HasColumnName("Id");
            this.Property(t => t.FeedBackID).HasColumnName("FeedBackID");
            this.Property(t => t.Type1).HasColumnName("Type1");
            this.Property(t => t.Type2).HasColumnName("Type2");
            this.Property(t => t.Type3).HasColumnName("Type3");
            this.Property(t => t.Type4).HasColumnName("Type4");
            this.Property(t => t.Type5).HasColumnName("Type5");



            this.HasRequired<Feedback>(c => c.Feedback)
                 .WithMany(f => f.FeedbackScoreRecord)
                 .HasForeignKey<Int64>(c => c.FeedBackID);





            //using (var ctx = new FeedbackScoreContext())
            //{
            //    var studentList = ctx.Students.Where(s => s.StudentName == "Bill").ToList();
            //    var res = from e1 in emp1
            //              join e2 in emp2
            //                  on e1.emp_id equals e2.emp_id
            //              select new
            //              {
            //                  Emp_Name = e1.emp_name,
            //                  Emp_Salary = e2.emp_salary
            //              };
            /*  foreach (var val in res)
              {
                  Console.WriteLine("Employee Name: {0} Salary: {1}",
                                       val.Emp_Name, val.Emp_Salary);*/
        }
    }
}

