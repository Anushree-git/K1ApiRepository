using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using K1Api.Models;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity.ModelConfiguration;

namespace K1Api.Context.Mapping
{
    public class ServiceAreaMap : EntityTypeConfiguration<ServiceArea>
    {
        public ServiceAreaMap()
        {
            // Primary Key
            this.HasKey(t => t.Id);

            // Properties
            this.Property(t => t.AreaName)
                .IsRequired()
                .HasMaxLength(40);

            // Table & Column Mappings
            this.ToTable("ServiceArea");
            this.Property(t => t.Id).HasColumnName("Id");
            this.Property(t => t.AreaName).HasColumnName("AreaName");
        }
    }
}