using System.ComponentModel.DataAnnotations;
using System.Data.Entity.ModelConfiguration;
using K1Api.Models;

namespace K1Api.Context.Mapping
{
    public class CustomerMap : EntityTypeConfiguration<Customer>
    {
        public CustomerMap()
        {
            //Primary key
            this.HasKey(t => t.Id);
           //Properties
            this.Property(t => t.FName).HasMaxLength(80);
            this.Property(t => t.LName).HasMaxLength(80);
            this.Property(t => t.EmailId).HasMaxLength(80);
            this.Property(t => t.PhoneNo).HasMaxLength(80);
            //table column mapping
            this.ToTable("Customer");
            this.Property(t => t.Id).HasColumnName("Id");
            this.Property(t => t.FName).HasColumnName("FirstName");
            this.Property(t => t.LName).HasColumnName("LastName");
            this.Property(t => t.EmailId).HasColumnName("EmailId");
            this.Property(t => t.PhoneNo).HasColumnName("PhoneNumber");
        }
    }
}