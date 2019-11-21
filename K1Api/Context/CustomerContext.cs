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
    public partial class CustomerContext : DbContext //A DbContext instance represents a combination of the Unit Of Work
                                                                                //and Repository patterns such that it can be used to query from a database
                                                                               //and group together changes that will then be written back to the store as a unit. 
    {
        static CustomerContext()
        {
            Database.SetInitializer<CustomerContext>(null);
        }
        public CustomerContext()
            : base("RestrauntfeedbackContext")
        {
        }
        //<Entity>EntitySet
        public DbSet<Customer> Customers { get; set; }  //DbSet<TEntity> is a property in DbContext which maps class to database table

        protected override void OnModelCreating(DbModelBuilder modelBuilder)  //only inherited class can access this method & overrides the virtul method.
        {
            modelBuilder.Configurations.Add(new CustomerMap());
        }

    }
}