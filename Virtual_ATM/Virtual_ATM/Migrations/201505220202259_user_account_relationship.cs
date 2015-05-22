namespace Virtual_ATM.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class user_account_relationship : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Accounts",
                c => new
                    {
                        Id = c.Int(nullable: false),
                        CustomerNumber = c.String(),
                        AccountNumber = c.String(),
                        AccountBalance = c.Decimal(nullable: false, precision: 18, scale: 2),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Users", t => t.Id)
                .Index(t => t.Id);
            
            CreateTable(
                "dbo.Users",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Address = c.String(),
                        Password = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Accounts", "Id", "dbo.Users");
            DropIndex("dbo.Accounts", new[] { "Id" });
            DropTable("dbo.Users");
            DropTable("dbo.Accounts");
        }
    }
}
