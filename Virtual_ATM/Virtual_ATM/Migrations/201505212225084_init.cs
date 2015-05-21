namespace Virtual_ATM.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class init : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.AccountModels",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        CustomerNumber = c.String(),
                        AccountNumber = c.String(),
                        AccountBalance = c.Decimal(nullable: false, precision: 18, scale: 2),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.UserModels",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Address = c.String(),
                        CustomerNumber_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.AccountModels", t => t.CustomerNumber_Id)
                .Index(t => t.CustomerNumber_Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.UserModels", "CustomerNumber_Id", "dbo.AccountModels");
            DropIndex("dbo.UserModels", new[] { "CustomerNumber_Id" });
            DropTable("dbo.UserModels");
            DropTable("dbo.AccountModels");
        }
    }
}
