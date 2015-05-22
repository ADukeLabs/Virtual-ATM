using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Virtual_ATM.Model;

namespace Virtual_ATM
{
   public class AtmModel
    {

       AtmDBcontext db = new AtmDBcontext();
       UserModel user = new UserModel();
       AccountModel account = new AccountModel();
       AtmView view = new AtmView();
      
        
       
       public void Withdraw( string customerNumber)
        {
            Console.WriteLine("How much would you like to withdraw from your account today?");
            int withdrawAmount = int.Parse( Console.ReadLine());
            var n = db.Accounts.FirstOrDefault(x => x.CustomerNumber == customerNumber);
            decimal balance = n.AccountBalance - withdrawAmount;
            if (balance > 0)
            {
                n.AccountBalance = balance;
                decimal b=n.AccountBalance - balance;
                  view.ShowBalance(b);
                
            }
            else
            {
                
                view.NOBalance();
            }

            db.SaveChanges();
        }

        public void Deposit( string customerNumber)
        {
            Console.WriteLine("How much would you like to deposit today?");
            int depositAmount = int.Parse(Console.ReadLine());

            var n = db.Accounts.FirstOrDefault(x => x.CustomerNumber == customerNumber);
            decimal balance = n.AccountBalance + depositAmount;



            view.ShowBalance(balance);
        



            db.SaveChanges();


        }

        public void LogOff()
        {
            Console.Clear();

        }


       //public void DisplayBalance()
       //{
           
       //}

       //public void Create()
       //{
       ////     public int Id { get; set; }
       ////public string Name { get; set; }
       ////public string Address { get; set; }
       ////public string Password { get; set; }
       //////public int Paygrade { get; set; }
       ////public virtual AccountModel CustomerNumber { get; set; }
       //    Console.WriteLine("enter ur name");
       //    string name = Console.ReadLine();
       //    Console.WriteLine("enter ur Addrss");
       //    string adress = Console.ReadLine();
       //    Console.WriteLine("enter ur password");
       //    string pswd = Console.ReadLine();


       //    Random random = new Random();
       //   string cusnum = random.Next(100000, 999999).ToString();
           


       //    db.Users.Add(new UserModel() {Address = adress, Name = name, Password = pswd,CustomerNumber = account.CustomerNumber=cusnum});



       //}
    }
}
