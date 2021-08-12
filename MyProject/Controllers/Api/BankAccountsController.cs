using MyProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace MyProject.Controllers.Api
{
    public class BankAccountsController : ApiController
    {
        private ApplicationDbContext _context;


        public BankAccountsController()
        {
            _context = new ApplicationDbContext();
        }       
       //GET/api/bankAccounts
        public IEnumerable<BankAccount> GetBankAccounts()
        {
            return _context.BankAccounts.ToList();
        }
        //GET/api/bankAccounts/1

        public BankAccount GetBankAccount(int id)
        {
            var bankAccount = _context.BankAccounts.SingleOrDefault(c => c.Id == id);
            if (bankAccount == null)
                throw new HttpResponseException(HttpStatusCode.NotFound);
            return bankAccount;
        }

        //POST/api/bankAccounts
        [HttpPost]
        public BankAccount CreateBankAccount(BankAccount bankAccount)
        {
            if (!ModelState.IsValid)
                throw new HttpResponseException(HttpStatusCode.BadRequest);
            _context.BankAccounts.Add(bankAccount);
            _context.SaveChanges();

            return bankAccount; 
        }

        //Put/api/bankAccounts/1
        [HttpPut]
        public void UpdateBankAccount(int id, BankAccount bankAccount)
        {
            if (!ModelState.IsValid)
                throw new HttpResponseException(HttpStatusCode.BadRequest);


            var bankAccountInDb = _context.BankAccounts.SingleOrDefault(c => c.Id == id);

            if (bankAccountInDb == null)
                throw new HttpResponseException(HttpStatusCode.NotFound);


                bankAccountInDb.AccountNumber = bankAccount.AccountNumber;

                 _context.SaveChanges();
        }

        //Delete/api/bankAccounts/1
        [HttpDelete]
        public void DeleteBankAccount(int id)
        {
            var bankAccountInDb = _context.BankAccounts.SingleOrDefault(c => c.Id == id);

            if (bankAccountInDb == null)
                throw new HttpResponseException(HttpStatusCode.NotFound);

            _context.BankAccounts.Remove(bankAccountInDb);
            _context.SaveChanges();
        }



    }
}
