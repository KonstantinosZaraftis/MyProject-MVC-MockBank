namespace MyProject.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class newagain : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.BankAccounts", "CardId", "dbo.Cards");
            DropForeignKey("dbo.Customers", "BankAccount_Id", "dbo.BankAccounts");
            DropIndex("dbo.BankAccounts", new[] { "CardId" });
            DropIndex("dbo.Customers", new[] { "BankAccount_Id" });
            DropPrimaryKey("dbo.Cards");
            AddColumn("dbo.BankAccounts", "Customer_Id", c => c.String(maxLength: 128));
            AddColumn("dbo.Customers", "CardId", c => c.Int());
            AlterColumn("dbo.Cards", "Id", c => c.Int(nullable: false));
            AddPrimaryKey("dbo.Cards", "Id");
            CreateIndex("dbo.BankAccounts", "Customer_Id");
            CreateIndex("dbo.Cards", "Id");
            AddForeignKey("dbo.BankAccounts", "Customer_Id", "dbo.AspNetUsers", "Id");
            AddForeignKey("dbo.Cards", "Id", "dbo.Customers", "Id");
            DropColumn("dbo.BankAccounts", "CardId");
            DropColumn("dbo.Customers", "BankAccount_Id");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Customers", "BankAccount_Id", c => c.Int());
            AddColumn("dbo.BankAccounts", "CardId", c => c.Int());
            DropForeignKey("dbo.Cards", "Id", "dbo.Customers");
            DropForeignKey("dbo.BankAccounts", "Customer_Id", "dbo.AspNetUsers");
            DropIndex("dbo.Cards", new[] { "Id" });
            DropIndex("dbo.BankAccounts", new[] { "Customer_Id" });
            DropPrimaryKey("dbo.Cards");
            AlterColumn("dbo.Cards", "Id", c => c.Int(nullable: false, identity: true));
            DropColumn("dbo.Customers", "CardId");
            DropColumn("dbo.BankAccounts", "Customer_Id");
            AddPrimaryKey("dbo.Cards", "Id");
            CreateIndex("dbo.Customers", "BankAccount_Id");
            CreateIndex("dbo.BankAccounts", "CardId");
            AddForeignKey("dbo.Customers", "BankAccount_Id", "dbo.BankAccounts", "Id");
            AddForeignKey("dbo.BankAccounts", "CardId", "dbo.Cards", "Id");
        }
    }
}
