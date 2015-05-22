using System.Collections.Generic;
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
              new User { Name = "Max Lott", Address = "222 Wills Street", Password = "3022", },
              new User { Name = "Alex Duke", Address = "75a Volga Street", Password = "2057" },
              new User { Name = "Matt Bullock", Address = "420 Cuba Street", Password = "6293" },
              new User { Name = "Darcy Thomas", Address = "1000 Some Street", Password = "1234" },
              new User { Name = "Deepika Jovy", Address = "57 Manners Street", Password = "9242" }
            ); context.SaveChanges();


            List<Account> accounts = new List<Account>()
            {
              new Account { CustomerNumber = "472839", AccountNumber = "02-4956-3663-50", AccountBalance = 0 },
              new Account { CustomerNumber = "678265", AccountNumber = "05-3401-6826-20", AccountBalance = 0 },
              new Account { CustomerNumber = "284126", AccountNumber = "08-4633-2361-10", AccountBalance = 0 },
              new Account { CustomerNumber = "123456", AccountNumber = "08-4633-2361-10", AccountBalance = 10000000 },
              new Account { CustomerNumber = "454353", AccountNumber = "01-1948-7913-80", AccountBalance = 0 }

            };

            //var accountWithIndex = accounts.Select((s, i) => new {index = i, account = s});

            //var q = context.Users.ToList()
            //    .Select((s, i) => new {index = i, user = s})
            //    .Join(accountWithIndex, u => u.index, i => i.index, (u, i) => new {account = i.account, user = u.user})
            //    .ToList();

            //q.ForEach(f => f.account.User = f.user);


            int n = 0;
            var users = context.Users.Take(accounts.Count()).ToList();
             foreach (var account in accounts)
             {
                 account.User = users[n];
                n++;
            }


            //context.Users.First(f => f.Name == "Darcy Thomas").Account.AccountBalance.

            context.Accounts.AddOrUpdate(
              p => p.CustomerNumber,
                accounts.ToArray()
            );

            //context.Accounts.First().User = context.Users.First();
            //context.SaveChanges();

        }
    }
}
