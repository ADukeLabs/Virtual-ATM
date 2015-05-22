using Virtual_ATM.Model;

namespace Virtual_ATM.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<Virtual_ATM.AtmDBcontext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(Virtual_ATM.AtmDBcontext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data. E.g.
            //
            context.Users.AddOrUpdate(
              p => p.Name,
              new UserModel { Name = "Max Lott", Address = "222 Wills Street", Password = "3022"},
              new UserModel { Name = "Alex Duke", Address = "75a Volga Street", Password = "2057"},
              new UserModel { Name = "Matt Bullock", Address = "420 Cuba Street", Password = "6293"},
              new UserModel { Name = "Deepika Jovy", Address = "57 Manners Street", Password = "9242"}
            );

            context.Accounts.AddOrUpdate(
              p => p.CustomerNumber,
              new AccountModel { CustomerNumber = "472839", AccountNumber = "02-4956-3663-50", AccountBalance = 0},
              new AccountModel { CustomerNumber = "678265", AccountNumber = "05-3401-6826-20", AccountBalance = 0},
              new AccountModel { CustomerNumber = "284126", AccountNumber = "08-4633-2361-10", AccountBalance = 0},
              new AccountModel { CustomerNumber = "454353", AccountNumber = "01-1948-7913-80", AccountBalance = 0}

            );
            
        }
    }
}
