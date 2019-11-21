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
    public class K1EmployeeController : ApiController
    {
        EmployeeRepository empRepositoryObj = new EmployeeRepository(new EmployeeContext());

        [HttpGet]
        [Route("api/Employee/Get")]
        public IHttpActionResult GetEmployee()
        {
            List<Employee> employeeList = empRepositoryObj.GetEmployees().ToList();

            try
            {
                return Ok(employeeList);
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }

        [HttpPost]
        [Route("api/Employee/List")]
        public IHttpActionResult GetEmployeeList()
        {
            List<Employee> employeeList = empRepositoryObj.GetEmployees().ToList();
            try
            {
                return Ok(employeeList);
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);//dont use notfound always return any message 
            }
        }



        [HttpPost]
        [Route("api/Employee/Insert")]
        public IHttpActionResult InsertEmployee([FromBody]Employee employee)
        {
            Employee addEmployee = empRepositoryObj.InsertEmployee(employee);
            empRepositoryObj.Save();
            try
            {
                return Ok("employee inserted successfully");
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }

        [HttpPost]
        [Route("api/Employee/Delete")]
        public IHttpActionResult DeleteEmployee([FromBody]int employeeId)
        {
            Employee delEmployee = empRepositoryObj.DeleteEmployee(employeeId);
            empRepositoryObj.Save();
            try
            {
                return Ok("employee deleted successfully");
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }

    }
}



