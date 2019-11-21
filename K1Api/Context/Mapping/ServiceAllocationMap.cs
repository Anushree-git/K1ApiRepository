using System.Data.Entity.ModelConfiguration;
using System.ComponentModel.DataAnnotations;
using K1Api.Models;
using System;

namespace K1Api.Context.Mapping
{
    public class ServiceAllocationMap : EntityTypeConfiguration<ServiceAllocation>
    {
        public ServiceAllocationMap()
        {
            this.HasKey(s => s.Id);

            this.Property(s => s.EmpId);
            this.Property(s => s.ShiftDate);
            this.Property(s => s.shiftendtime);
            this.Property(s => s.shiftstartTime);
            this.Property(s => s.ServiceAreaId);

            this.ToTable("ServiceAllocations");
            this.Property(s => s.Id).HasColumnName("Id");
            this.Property(s => s.EmpId).HasColumnName("EmpId");
            this.Property(s => s.ShiftDate).HasColumnName("ShiftDate");
            this.Property(s => s.shiftendtime).HasColumnName("shiftendtime");
            this.Property(s => s.shiftstartTime).HasColumnName("shiftstartTime");
            this.Property(s => s.ServiceAreaId).HasColumnName("ServiceAreaId");

            this.HasRequired<Employee>(c => c.Employee)
                .WithMany(f => f.ServiceAllocationRecord)
                .HasForeignKey<int>(c => c.EmpId);

            this.HasRequired<ServiceArea>(c => c.ServiceArea)
                .WithMany(f => f.ServiceAllocationRecords)
                .HasForeignKey<Int64>(c => c.ServiceAreaId);



        }


    }
}