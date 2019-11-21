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

    public partial class ServiceAllocationContext : DbContext
    {
        static ServiceAllocationContext()
        {
            Database.SetInitializer<ServiceAllocationContext>(null);
        }
        public ServiceAllocationContext()
            : base("Name=RestrauntfeedbackContext")
        {
        }
        public DbSet<ServiceAllocation> ServiceAllocations { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new ServiceAllocationMap());

        }
    }
}
