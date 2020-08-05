using MyProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MyProject.Controllers
{
    public class BankAccountController : Controller
    {
        ApplicationDbContext db = new ApplicationDbContext();

        // GET: BankAccount
        public ActionResult Index()
        {
            var accounts = db.BankAccounts.ToList();

            return View(accounts);
        }
    }
}