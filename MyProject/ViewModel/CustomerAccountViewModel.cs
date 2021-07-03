using MyProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MyProject.ViewModel
{
    public class CustomerAccountViewModel
    {
        public Customer Customer { get; set; }
        public List<BankAccount> BankAccounts { get; set; }




    }
}