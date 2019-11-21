using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity.ModelConfiguration;
using K1Api.Models;

namespace K1Api.Context.Mapping
{
    public class EventMap : EntityTypeConfiguration<Event>
    {
        public EventMap()
        {
            this.HasKey(e => e.Id);

            this.Property(e => e.CustomerID);
            this.Property(e => e.EventDateTime);
            this.Property(e => e.EventTypeId);

            this.ToTable("EventTable");
            this.Property(e => e.CustomerID).HasColumnName("Id");
            this.Property(e => e.CustomerID).HasColumnName("CustomerID");
            this.Property(e => e.EventDateTime).HasColumnName("EventDateTime");
            this.Property(e => e.EventTypeId).HasColumnName("EventTypeId");


            this.HasRequired<EventType>(e => e.EventType)
                 .WithMany(e => e.EventRecord)
                 .HasForeignKey<int>(e => e.EventTypeId);

            
        }
    }
}