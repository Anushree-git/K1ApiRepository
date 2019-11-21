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
    
        public partial class EmployeeContext : DbContext
    {
        static EmployeeContext()
        {
            Database.SetInitializer<EmployeeContext>(null);
        }
        public EmployeeContext()
            : base("Name=RestrauntfeedbackContext")   //here if instead("Name:RestrauntfeedbackContext") it willn't connect to db!!!
        {
        }
        public DbSet<Employee> Employees { get; set; }

            protected override void OnModelCreating(DbModelBuilder modelBuilder)
            {
                modelBuilder.Configurations.Add(new EmployeeMap());

            }
        }
    }
