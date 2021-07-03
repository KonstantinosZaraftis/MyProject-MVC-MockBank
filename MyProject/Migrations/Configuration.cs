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
            Customer c1 = new Customer() { FirstName = "Kostas", LastName = "Zaraftis", Address = "Ampabris", PhoneNumber = "6946337409", CardId = 1 };
            context.Customers.AddOrUpdate(c => c.FirstName, c1);

            Card a1 = new Card() { CardNumber = "430589875462", BankAccountId = 1 };
            context.Cards.AddOrUpdate(a => a.CardNumber, a1);
            BankAccount b1 = new BankAccount() { AccountNumber = "57070465841275" };
            context.BankAccounts.AddOrUpdate(b => b.AccountNumber, b1);
        }
    }
}
