using Storly.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Data.Entity;

namespace Storly.Controllers.api
{
    public class CustomerController : ApiController
    {
        private ApplicationDbContext dbContext;

        public CustomerController()
        {
            dbContext = new ApplicationDbContext();
        }

        protected override void Dispose(bool disposing)
        {
            dbContext.Dispose();
        }

        [HttpGet]
        public IEnumerable<Customer> GetCustomer ()
        {
            var customer = dbContext.Customer.ToList();
            return customer;
        }
        [HttpPost]
        public Customer AddCustomer(Customer customer)
        {
            //if (customer == null)
            //   return 
            dbContext.Customer.Add(customer);
            dbContext.SaveChanges();
            return customer;
        }
        [HttpPut]
        public Customer UpdateCustomer(int id,Customer customer)
        {
            var customerInDb = dbContext.Customer.SingleOrDefault(c => c.Id == id);
            if(customerInDb == null)
            {

            }
            customerInDb.Name = customer.Name;
            customerInDb.MemberShipTypeId = customer.MemberShipTypeId;
            customerInDb.BirthDate = customer.BirthDate;
            dbContext.SaveChanges();
            return customerInDb;
        }
    }
}
