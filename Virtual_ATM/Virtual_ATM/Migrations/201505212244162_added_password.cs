namespace Virtual_ATM.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class added_password : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.UserModels", "Password", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.UserModels", "Password");
        }
    }
}
