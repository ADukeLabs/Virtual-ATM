namespace Virtual_ATM.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class added_ref_to_account : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.UserModels", "CustomerNumber_Id", "dbo.AccountModels");
            DropIndex("dbo.UserModels", new[] { "CustomerNumber_Id" });
            DropColumn("dbo.AccountModels", "Id");
            RenameColumn(table: "dbo.AccountModels", name: "CustomerNumber_Id", newName: "Id");
            DropPrimaryKey("dbo.AccountModels");
            AlterColumn("dbo.AccountModels", "Id", c => c.Int(nullable: false));
            AddPrimaryKey("dbo.AccountModels", "Id");
            CreateIndex("dbo.AccountModels", "Id");
            DropColumn("dbo.UserModels", "CustomerNumber_Id");
        }
        
        public override void Down()
        {
            AddColumn("dbo.UserModels", "CustomerNumber_Id", c => c.Int());
            DropIndex("dbo.AccountModels", new[] { "Id" });
            DropPrimaryKey("dbo.AccountModels");
            AlterColumn("dbo.AccountModels", "Id", c => c.Int(nullable: false, identity: true));
            AddPrimaryKey("dbo.AccountModels", "Id");
            RenameColumn(table: "dbo.AccountModels", name: "Id", newName: "CustomerNumber_Id");
            AddColumn("dbo.AccountModels", "Id", c => c.Int(nullable: false, identity: true));
            CreateIndex("dbo.UserModels", "CustomerNumber_Id");
            AddForeignKey("dbo.UserModels", "CustomerNumber_Id", "dbo.AccountModels", "Id");
        }
    }
}
