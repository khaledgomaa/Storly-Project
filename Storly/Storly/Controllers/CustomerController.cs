using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Storly.Models;
using System.Data.Entity;
using Storly.ViewModels;

namespace Storly.Controllers
{
    public class CustomerController : Controller
    {
        // GET: Customer
        private ApplicationDbContext dbContext;

        public CustomerController()
        {
            dbContext = new ApplicationDbContext();                                                    
        }

        protected override void Dispose(bool disposing)
        {
            dbContext.Dispose();
        }

        public ActionResult New()
        {
            var customerViewModel = new CustomerViewModel
            {
<<<<<<< HEAD
                MemberShip = dbContext.MemberShip.ToList()       
=======
                MemberShip = dbContext.MemberShip.ToList(),  
                Customer = new Customer(),     
>>>>>>> Adding dataTables and using ajax to call web api
            };

            return View(customerViewModel);
        }

        [HttpPost]
<<<<<<< HEAD
        public ActionResult Create(Customer customer)
        {
            if(customer.Id == 0)
            {
                dbContext.Customer.Add(customer);
            }
            var customerInDb = dbContext.Customer.SingleOrDefault(c => c.Id == customer.Id);
            customerInDb.Name = customer.Name;
            customerInDb.MemberShipTypeId = customer.MemberShipTypeId;
            customerInDb.IsSubscribedByMemberShip = customer.IsSubscribedByMemberShip;
=======
        [ValidateAntiForgeryToken]
        public ActionResult Create(Customer customer)
        {
            if (!(ModelState.IsValid))
            {
                foreach (ModelState modelstate in ViewData.ModelState.Values)
                {
                    foreach (ModelError modelerror in modelstate.Errors)
                    {
                        string error = modelerror.ErrorMessage;
                    }
                }
                var customerViewModel = new CustomerViewModel
                {
                    Customer = customer,
                    MemberShip = dbContext.MemberShip.ToList(),
                };
                return View("New", customerViewModel);
            }
            if (customer.Id == 0)
            {
                dbContext.Customer.Add(customer);
            }
            else
            {
                var customerInDb = dbContext.Customer.SingleOrDefault(c => c.Id == customer.Id);
                customerInDb.Name = customer.Name;
                customerInDb.MemberShipTypeId = customer.MemberShipTypeId;
                customerInDb.IsSubscribedByMemberShip = customer.IsSubscribedByMemberShip;
                customerInDb.BirthDate = customer.BirthDate;
            }
            
>>>>>>> Adding dataTables and using ajax to call web api
            dbContext.SaveChanges();
            return RedirectToAction("Index", "Customer");
        }
        
        public ActionResult Edit(int id)
        {
            var customerInDb = dbContext.Customer.SingleOrDefault(c => c.Id == id);
            if (customerInDb == null)
            {
                return HttpNotFound();
            }
            var customerViewModel = new CustomerViewModel
            {
                Customer = customerInDb,
                MemberShip = dbContext.MemberShip.ToList()
            };
            return View("New", customerViewModel);
        }
        
        public ActionResult Delete(int id)
        {
            var customerInDb = dbContext.Customer.SingleOrDefault(c => c.Id == id);
            if (customerInDb == null)
                return HttpNotFound();
            dbContext.Customer.Remove(customerInDb);
            dbContext.SaveChanges();
            return RedirectToAction("Index", "Customer");
        }

        public ViewResult Index()
        {
            var customer = dbContext.Customer.Include(c=>c.MembershipType).ToList();
            return View(customer);
        }
        public ActionResult Details(int id)
        {
            var customer = dbContext.Customer.Include(c=>c.MembershipType).SingleOrDefault(c => c.Id == id);
            if(customer==null)
            {
                return HttpNotFound();
            }
            return View(customer);
        }

    }
}