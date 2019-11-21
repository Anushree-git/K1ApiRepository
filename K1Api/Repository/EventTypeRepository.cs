using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using K1Api.Models;
using K1Api.Context;


namespace K1Api.Repository
{
    public class EventTypeRepository : IDisposable
    {
        private EventTypesContext context;

        public EventTypeRepository(EventTypesContext context)
        {
            this.context = context;
        }

        public EventTypeRepository()
        {
            // To do: Complete member initialization
        }

        public IEnumerable<EventType> GetEventTypes()
        {
            return context.EventTypes.ToList();
        }
        public IEnumerable<EventType> GetEventTypeList()
        {
            return context.EventTypes.ToList();
        }


        public EventType InsertEventType(EventType eventType)
        {
            return context.EventTypes.Add(eventType);

        }

        public EventType DeleteEventType(int EventTypeId)
        {
            EventType eventType = context.EventTypes.Find(EventTypeId);
            return context.EventTypes.Remove(eventType);
        }


        public void Save()
        {
            this.context.SaveChanges();
        }

        public void Dispose()
        {
            this.context.Dispose();
        }


    }

}
