//using System;
//using System.Collections.Generic;
//using System.Threading.Tasks;
//using System.Web.Helpers;
//using System.Web.Http;
//using Microsoft.VisualStudio.TestTools.UnitTesting;
//using K1Api.Controllers;
//using K1Api.Models;

//namespace K1Api.Tests
//{
//    [TestClass]
//    public class TestCustomerController
//    {
//        [TestMethod]
//        public void GetAllCustomersList()
//        {
//            var testCustomers = GetTestCustomer();
//            var controller = new SimpleCustomerController(testCustomers);

//            var result = controller.GetTestCustomer() as List<Product>;
//            Assert.AreEqual(testCustomers.Count, result.Count);
//        }

//        [TestMethod]
//        public async Task GetAllProductsAsyncs()
//        {
//            var testProducts = GetTestCustomer();
//            var controller = new SimpleCustomerController(testCustomers);

//            var result = await controller.GetAllCustomersAsync() as List<Customer>;
//            Assert.AreEqual(testProducts.Count, result.Count);
//        }
//        private List<Customer> GetTestCustomer()
//        {
//            var testCustomers = new List<Customer>();
//            testCustomers.Add(new Customer { Id = 3, FName = "ananya", LName = "lakshmi", EmailId = "natikeri.com", PhoneNo = "9562314741" });
//            return testCustomers;
//        }

//    }
//}
 

        