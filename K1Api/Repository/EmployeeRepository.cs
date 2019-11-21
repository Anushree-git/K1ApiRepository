using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using K1Api.Models;
using K1Api.Context;
using System.Data.Entity;
using System.Web.Http.Filters;

namespace K1Api.Repository
{
    public class EmployeeRepository : IDisposable
    {

        private EmployeeContext context;   //An instance of the context class represents Unit Of Work and Repository patterns
        //wherein it can combine multiple changes under a single database transaction.

        public EmployeeRepository(EmployeeContext context)
        {
            this.context = context;
        }

        public EmployeeRepository()
        {
            // To do: Complete member initialization
        }
        public IEnumerable<Employee> GetEmployees()
        {
            return context.Employees.ToList();
        }
       
        public IEnumerable<Employee> GetEmployeeList()
        {
            return context.Employees.ToList();
        }

        public Employee InsertEmployee(Employee employee)
        {
            return context.Employees.Add(employee);

        }

        public Employee DeleteEmployee(int employeeId)
        {
            Employee employee = context.Employees.Find(employeeId);
            return context.Employees.Remove(employee);
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