using MyProject.Models;
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
            var customer = db.Customers.ToList();//fernei olous tou customers apo thn bash


            return View(customer);
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