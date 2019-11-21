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
    public class K1ServiceAreaController : ApiController
    {
        ServiceAreaRepository serviceAreaRepositoryObj = new ServiceAreaRepository(new ServiceAreaContext());

        [HttpGet]
        [Route("api/ServiceArea/Get")]
        public IHttpActionResult GetServiceArea()
        {
            List<ServiceArea> serviceAreaList = serviceAreaRepositoryObj.GetServiceAreas().ToList();

            try
            {
                return Ok(serviceAreaList);
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }

        [HttpPost]
        [Route("api/ServiceArea/List")]
        public IHttpActionResult GetServiceAreaList()
        {
            List<ServiceArea> serviceAreaList = serviceAreaRepositoryObj.GetServiceAreaList().ToList();
            try
            {
                return Ok(serviceAreaList);
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);//dont use notfound always return any message 
            }
        }



        [HttpPost]
        [Route("api/ServiceArea/Insert")]
        public IHttpActionResult InsertServiceAreas([FromBody]ServiceArea serviceArea)
        {
            ServiceArea addServiceArea = serviceAreaRepositoryObj.InsertServiceArea(serviceArea);
            serviceAreaRepositoryObj.Save();
            try
            {
                return Ok("serviceArea inserted successfully");
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }

        [HttpPost]
        [Route("api/ServiceArea/Delete")]
        public IHttpActionResult DeleteServiceArea([FromBody]int serviceAreaId)
        {
            ServiceArea delServiceArea = serviceAreaRepositoryObj.DeleteServiceArea(serviceAreaId);
            serviceAreaRepositoryObj.Save();
            try
            {
                return Ok("serviceArea deleted successfully");
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }



    }
}



