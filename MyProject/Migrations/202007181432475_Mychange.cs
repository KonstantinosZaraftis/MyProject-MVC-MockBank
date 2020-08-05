namespace MyProject.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Mychange : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Customers", "BankAccount_Id", c => c.Int());
            CreateIndex("dbo.Customers", "BankAccount_Id");
            AddForeignKey("dbo.Customers", "BankAccount_Id", "dbo.BankAccounts", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Customers", "BankAccount_Id", "dbo.BankAccounts");
            DropIndex("dbo.Customers", new[] { "BankAccount_Id" });
            DropColumn("dbo.Customers", "BankAccount_Id");
        }
    }
}
