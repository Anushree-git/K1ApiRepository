using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using K1Api.Models;
using K1Api.Context.Mapping;

namespace K1Api.Context
{
    public partial class EventContext : DbContext
    {
        static EventContext()
        {
            Database.SetInitializer<EventContext>(null);
        }
        public EventContext()
            : base("Name=RestrauntfeedbackContext")
        {
        }
        public DbSet<Event> Events { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new EventMap());

        }
    }
}