//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Web;
//using System.Data.Entity;
//using System.Data.Entity.Infrastructure;
//using K1Api.Models;
//using K1Api.Context;

//namespace K1Api.Context
//{
//    public class BaseDbContext<TContext> : DbContext where TContext : DbContext
//    {
//        static BaseDbContext()
//        {
//            Database.SetInitializer<TContext>(null);
//        }
//        public BaseDbContext()
//            : base("Name:RestrauntfeedbackContext")
//        {
//            this.Configuration.ProxyCreationEnabled = false;
//            this.Configuration.LazyLoadingEnabled = false;
//        }
//        public BaseDbContext(string RestrauntfeedbackContext) : base(RestrauntfeedbackContext)
//        {
//            this.Configuration.ProxyCreationEnabled = false;
//            this.Configuration.LazyLoadingEnabled = false;
//        }
//    }
//}