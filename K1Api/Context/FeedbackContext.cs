
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using K1Api.Models;
using K1Api.Context.Mapping;


namespace K1Api.Context
{
    public partial class FeedbackContext : DbContext
    {
        static FeedbackContext()
        {
            Database.SetInitializer<FeedbackContext>(null);
        }
        public FeedbackContext()
            : base("Name=RestrauntfeedbackContext")
        {
        }
        public DbSet<Feedback> Feedbacks { get; set; }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new FeedbackMap());

        }
    }
}