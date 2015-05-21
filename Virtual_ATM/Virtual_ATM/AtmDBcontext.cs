using Virtual_ATM.Model;

namespace Virtual_ATM
{
    using System;
    using System.Data.Entity;
    using System.Linq;

    public class AtmDBcontext : DbContext
    {
        // Your context has been configured to use a 'AtmDBcontext' connection string from your application's 
        // configuration file (App.config or Web.config). By default, this connection string targets the 
        // 'Virtual_ATM.AtmDBcontext' database on your LocalDb instance. 
        // 
        // If you wish to target a different database and/or database provider, modify the 'AtmDBcontext' 
        // connection string in the application configuration file.
        public AtmDBcontext()
            : base("name=AtmDBcontext")
        {
        }


        // Add a DbSet for each entity type that you want to include in your model. For more information 
        // on configuring and using a Code First model, see http://go.microsoft.com/fwlink/?LinkId=390109.

         public virtual DbSet<UserModel> Users { get; set; }
         public virtual DbSet<AccountModel> Accounts { get; set; }
    }

    //public class MyEntity
    //{
    //    public int Id { get; set; }
    //    public string Name { get; set; }
    //}
}