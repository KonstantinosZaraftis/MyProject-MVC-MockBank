using MyProject.Models;
using MyProject.ViewModel;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MyProject.Controllers
{
   
    public class CustomerController : Controller
    {
        ApplicationDbContext db = new ApplicationDbContext();
         public ActionResult AllCustomers()
         {
            var customers = db.Customers.ToList();
            return View(customers);
         }
        //GET: Customer
        //public ActionResult Index()
        //{
        //    ////var customer = db.Customers.Find(id);
        //    //var bankAccount = db.BankAccounts.ToList();

        //    //var customerAccountViewModel = new CustomerAccountViewModel
        //    //{
        //    //    //Customer = customer,
        //    //    BankAccounts = bankAccount

        //    //};

        //    return View(customerAccountViewModel);
        //}


        public ActionResult Create()//GET
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include= "Id,FirstName, LastName, Address, PhoneNumber")]Customer customer)//POST
         {
            if (ModelState.IsValid)
            {
                db.Customers.Add(customer);
                db.SaveChanges();
                return RedirectToAction("Index");
            }
          
            return View(customer);
         }

        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(System.Net.HttpStatusCode.BadRequest);
            }
            Customer customer = db.Customers.Find(id);
            if (customer == null)
            {
                return HttpNotFound();
            }
            return View(customer);
        }

        [HttpPost]
        public ActionResult Edit([Bind(Include= "Id,FirstName, LastName, Address, PhoneNumber")]Customer customer)
        {
            if (ModelState.IsValid)
            {
                db.Entry(customer).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(customer);
        }


        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(System.Net.HttpStatusCode.BadRequest);
            }
            Customer customer = db.Customers.Find(id);
            if (customer == null)
            {
                return HttpNotFound();
            }
            return View(customer);
        }

        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(System.Net.HttpStatusCode.BadRequest);
            }
            Customer customer = db.Customers.Find(id);
            if (customer == null)
            {
                return HttpNotFound();
            }
            return View(customer);
        }
        [HttpPost]
        [ActionName("Delete")]
        public ActionResult DeleteFoo(int id)
        {
            Customer customer = db.Customers.Find(id);
            if (customer == null)
            {
                return HttpNotFound();
            }
            db.Customers.Remove(customer);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}