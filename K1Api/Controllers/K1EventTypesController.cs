using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using K1Api.Repository;
using K1Api.Models;
using K1Api.Context;

namespace K1Api.Controllers
{
    public class K1EventTypesController : ApiController
    {
        EventTypeRepository eventRepositoryObj = new EventTypeRepository(new EventTypesContext());

        [HttpGet]
        [Route("api/EventType/Get")]
        public IHttpActionResult GetEventType()
        {
            List<EventType> eventTypeList = eventRepositoryObj.GetEventTypes().ToList();

            try
            {
                return Ok(eventTypeList);
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }

        [HttpPost]
        [Route("api/EventType/List")]
        public IHttpActionResult GetEventTypeList()
        {
            List<EventType> eventTypeList = eventRepositoryObj.GetEventTypes().ToList();
            try
            {
                return Ok(eventTypeList);
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);//dont use notfound always return any message 
            }
        }



        [HttpPost]
        [Route("api/EventType/Insert")]
        public IHttpActionResult InsertEventType([FromBody]EventType eventType)
        {
            EventType addeventType = eventRepositoryObj.InsertEventType(eventType);
            eventRepositoryObj.Save();
            try
            {
                return Ok("eventType inserted successfully");
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }

        [HttpPost]
        [Route("api/EventType/Delete")]
        public IHttpActionResult DeleteEventType([FromBody]int eventTypeId)
        {
            EventType delEventType = eventRepositoryObj.DeleteEventType(eventTypeId);
            eventRepositoryObj.Save();
            try
            {
                return Ok("eventType deleted successfully");
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }

    }
}



