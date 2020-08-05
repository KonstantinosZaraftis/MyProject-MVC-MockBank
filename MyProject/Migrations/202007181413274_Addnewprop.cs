namespace MyProject.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Addnewprop : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.BankAccounts", "Customer_Id", "dbo.Customers");
            DropIndex("dbo.BankAccounts", new[] { "Customer_Id" });
            AddColumn("dbo.Customers", "BankAccount", c => c.Int());
            DropColumn("dbo.BankAccounts", "Customer_Id");
        }
        
        public override void Down()
        {
            AddColumn("dbo.BankAccounts", "Customer_Id", c => c.Int());
            DropColumn("dbo.Customers", "BankAccount");
            CreateIndex("dbo.BankAccounts", "Customer_Id");
            AddForeignKey("dbo.BankAccounts", "Customer_Id", "dbo.Customers", "Id");
        }
    }
}
