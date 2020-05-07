using Storly.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Data.Entity;
<<<<<<< HEAD
=======
using Storly.Dtos;
using Storly.App_Start;
using AutoMapper;
using System.Data.Entity;
>>>>>>> Adding dataTables and using ajax to call web api

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
<<<<<<< HEAD
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
=======
        public IHttpActionResult GetCustomers ()
        {
            return Ok(dbContext.Customer.Include(m=>m.MembershipType).ToList().Select(Mapper.Map<Customer,CustomerDto>));
        }
        public IHttpActionResult GetCustomer(int id)
        {
            var customerInDb = dbContext.Customer.SingleOrDefault(c => c.Id == id);
            if (customerInDb == null)
                return NotFound();
            return Ok(Mapper.Map<Customer, CustomerDto>(customerInDb));
        }
        [HttpPost]
        public IHttpActionResult AddCustomer(CustomerDto customerDto)
        {
            if (!ModelState.IsValid)
                return BadRequest();
            var customer = Mapper.Map<CustomerDto, Customer>(customerDto);
            dbContext.Customer.Add(customer);
            dbContext.SaveChanges();
            //customerDto.Id = customer.Id;
            return Created(new Uri(Request.RequestUri + "/" + customer.Id),customer);
        }
        [HttpPut]
        public IHttpActionResult UpdateCustomer(int id,CustomerDto customerDto)
        {
            var customerInDb = dbContext.Customer.SingleOrDefault(c => c.Id == id);
            if (customerInDb == null)
                throw new HttpResponseException(HttpStatusCode.NotFound);
            Mapper.Map(customerDto, customerInDb);
            dbContext.SaveChanges();
            return Ok();
        }
        [HttpDelete]
        public IHttpActionResult DeleteCustomer(int id)
        {
            var CustomerInDb = dbContext.Customer.SingleOrDefault(m => m.Id == id);
            if (CustomerInDb == null)
                throw new HttpResponseException(HttpStatusCode.NotFound);
            dbContext.Customer.Remove(CustomerInDb);
            dbContext.SaveChanges();
            return Ok();
>>>>>>> Adding dataTables and using ajax to call web api
        }
    }
}
