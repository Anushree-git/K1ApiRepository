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
    //public interface ICustomerRepository : IDisposable
    //{
    //    IEnumerable<Customer> GetCustomers();
    //    Customer GetCustomerByID(int customerId);
    //    void InsertCustomer(Customer customer);
    //    void DeleteCustomer(int customerId);
    //    void Save();
    //}
    public class CustomerRepository : IDisposable
    {
        private CustomerContext context;   //An instance of the context class represents Unit Of Work and Repository patterns
                                          //wherein it can combine multiple changes under a single database transaction.

        public CustomerRepository(CustomerContext context)
        {
            this.context = context;
        }

        public CustomerRepository()
        {
            // To do: Complete member initialization
        }
        public IEnumerable<Customer> GetCustomers()
        {
            return context.Customers.ToList();
        }
        public IEnumerable<Customer> GetCustomerList()
        {
            return context.Customers.ToList();
        }


        public Customer InsertCustomer(Customer customer)
        {
          return context.Customers.Add(customer);
            
        }

        public Customer DeleteCustomer(int customerId)
        {
            Customer customer = context.Customers.Find(customerId);
            return context.Customers.Remove(customer);
        }

        public void Save()
        {
            this.context.SaveChanges();
        }

        public void Dispose()
        {
            this.context.Dispose();
        }
        //public IQueryable <Customer> FindByFilter(IFilter <Customer> filter)
        //{
        //    throw new NotImplementedException();
        //}
    }
}
//public Customer GetCustomerByID(int customerId)
//{
//    return context.Customers.Find(customerId);
//}