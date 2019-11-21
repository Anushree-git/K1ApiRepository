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
    public class K1CustomerController : ApiController
    {

        CustomerRepository custRepositoryObj = new CustomerRepository(new CustomerContext());


        [HttpGet]
        [Route("api/Customer/Get")]
        public IHttpActionResult GetCustomers()
        {
            
            List<Customer> customerList = custRepositoryObj.GetCustomers().ToList();

            try
            {
                return Ok(customerList);
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }

        [HttpPost]
        [Route("api/Customer/List")]
        public IHttpActionResult GetCustomerList()
        {
            List<Customer> customerList = custRepositoryObj.GetCustomerList().ToList();
            try
            {
                return Ok(customerList);
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);//dont use notfound always return any message 
            }
        }



        [HttpPost]
        [Route("api/Customer/Insert")]
        public IHttpActionResult InsertCustomers([FromBody]Customer customer)
        {
            Customer addCustomer = custRepositoryObj.InsertCustomer(customer);
            custRepositoryObj.Save();
            try
            {
                return Ok("customer inserted successfully");
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }

        [HttpPost]
        [Route("api/Customer/Delete")]
        public IHttpActionResult DeleteCustomers([FromBody]int customerId)
        {
            Customer delCustomer = custRepositoryObj.DeleteCustomer(customerId);
            custRepositoryObj.Save();
            try
            {
                return Ok("customer deleted successfully");
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }



    }
}
//[HttpPost]
//[Route("api/Customer/GetById")]
//public IHttpActionResult GetCustomerById([FromBody]int customerId)
//{
//    Customer customer = custRepositoryObj.GetCustomerByID(customerId);
//    try
//    {
//        return Ok(customer);
//    }
//    catch (Exception e)
//    {
//        return BadRequest(e.Message);
//    }
//}