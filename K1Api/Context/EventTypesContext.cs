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
    public partial class EventTypesContext :DbContext
    { 
        static EventTypesContext()
        {
            Database.SetInitializer<EventTypesContext>(null);
        }
        public EventTypesContext()
            : base("Name=RestrauntfeedbackContext")
        {
        }
        public DbSet<EventType> EventTypes { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new EventTypeMap());

        }
    }
}