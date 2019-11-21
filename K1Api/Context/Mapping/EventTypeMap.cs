using System;
using K1Api.Models;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity.ModelConfiguration;

namespace K1Api.Context.Mapping
{
    public class EventTypeMap : EntityTypeConfiguration<EventType>
    {
        public EventTypeMap()
        {
            // Primary Key
            this.HasKey(t => t.Id);

            // Properties
            this.Property(t => t.EventTypes)
                .IsRequired()
                .HasMaxLength(40);

            // Table & Column Mappings
            this.ToTable("EventTypeTable");
            this.Property(t => t.Id).HasColumnName("Id");
            this.Property(t => t.EventTypes).HasColumnName("EventType");

            

        }
    }
}
