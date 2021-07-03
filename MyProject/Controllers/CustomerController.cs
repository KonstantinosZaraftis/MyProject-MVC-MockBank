using MyProject.Models;
using MyProject.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MyProject.Controllers
{
   
    public class CustomerController : Controller
    {
        ApplicationDbContext db = new ApplicationDbContext();

        // GET: Customer
        public ActionResult Index()
        {
            var customer = db.Customers.SingleOrDefault();
            var bankAccount = db.BankAccounts.ToList();

            var customerAccountViewModel = new CustomerAccountViewModel{
                Customer=customer,
                BankAccounts=bankAccount

            };

            return View(customerAccountViewModel);
        }


        public ActionResult Create()//GET
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include= "Id,FIrstName,LastName,Address,PhoneNumber")]Customer customer)//POST
         {
            if (ModelState.IsValid)
            {
                db.Customers.Add(customer);
                db.SaveChanges();
            }
          
            return View();
         }
    }
}