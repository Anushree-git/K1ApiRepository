using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using K1Api.Models;
using K1Api.Context.Mapping;

namespace K1Api.Context
{
    
         public partial class FeedbackScoreContext : DbContext
    {
        static FeedbackScoreContext()
        {
            Database.SetInitializer<FeedbackScoreContext>(null);
        }
        public FeedbackScoreContext()
            : base("Name=RestrauntfeedbackContext")
        {
        }
        public DbSet<FeedbackScore> FeedbackScores { get; set; }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new FeedbackScoreMap());

        }
    }
}