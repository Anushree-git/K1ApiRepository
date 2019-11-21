using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using K1Api.Models;
using K1Api.Context;


namespace K1Api.Repository
{
    public class ServiceAreaRepository : IDisposable
    {
        private ServiceAreaContext context;

        public ServiceAreaRepository(ServiceAreaContext context)
        {
            this.context = context;
        }

        public ServiceAreaRepository()
        {
            // To do: Complete member initialization
        }

        public IEnumerable<ServiceArea> GetServiceAreas()
        {
            return context.ServiceAreas.ToList();
        }
        public IEnumerable<ServiceArea> GetServiceAreaList()
        {
            return context.ServiceAreas.ToList();
        }


        public ServiceArea InsertServiceArea(ServiceArea serviceArea)
        {
            return context.ServiceAreas.Add(serviceArea);

        }

        public ServiceArea DeleteServiceArea(int ServiceAreaId)
        {
            ServiceArea serviceArea = context.ServiceAreas.Find(ServiceAreaId);
            return context.ServiceAreas.Remove(serviceArea);
        }


        public void Save()
        {
            context.SaveChanges();
        }
        public void Dispose()
        {
            context.Dispose();
        }




    }

}
