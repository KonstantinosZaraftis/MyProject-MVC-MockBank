namespace MyProject.Migrations
{
    using MyProject.Models;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<MyProject.Models.ApplicationDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(MyProject.Models.ApplicationDbContext context)
        {
       
        Customer c1 = new Customer { FirstName = "Kostas", LastName = "Zaraftis", Address = "Ampabris", PhoneNumber = "694625346261" };
        Customer c2 = new Customer { FirstName = "Dimitr", LastName = "Arg", Address = "Athens", PhoneNumber = "696554256361" };
        context.Customers.AddOrUpdate(c => c.FirstName, c1, c2);


            BankAccount b1 = new BankAccount { AccountNumber = "57075040500" };
            BankAccount b2 = new BankAccount { AccountNumber = "57075055500" };

            context.BankAccounts.AddOrUpdate(b => b.AccountNumber, b1, b2);




            Card ca1 = new Card { CardNumber = "4305796582255" };
            Card ca2 = new Card { CardNumber = "4305796256255" };
            context.Cards.AddOrUpdate(a => a.CardNumber, ca1, ca2);

        }
    }
}
