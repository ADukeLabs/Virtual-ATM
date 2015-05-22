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
        AtmView view = new AtmView();
        
        public void Withdraw(string customerNumber)
        {
            Console.WriteLine("How much would you like to withdraw from your account today?");
            int withdrawAmount = int.Parse(Console.ReadLine());
            var n = db.Accounts.FirstOrDefault(x => x.CustomerNumber == customerNumber);
            decimal balance = n.AccountBalance - withdrawAmount;
            if (balance > 0)
            {
                n.AccountBalance = balance;
                //decimal b = n.AccountBalance - balance;
                view.ShowBalance(balance);
            }
            else
            {
                view.NOBalance();
            }
            
            db.SaveChanges();
        }

        public void Deposit(string customerNumber)
        {
            Console.WriteLine("How much would you like to deposit today?");
            int depositAmount = int.Parse(Console.ReadLine());
            var n = db.Accounts.FirstOrDefault(x => x.CustomerNumber == customerNumber);
            decimal balance = n.AccountBalance + depositAmount;
            
            n.AccountBalance = balance;
            view.ShowBalance(balance);
            db.SaveChanges();
        }

        public void Display(string name)
        {
            var n = db.Accounts.FirstOrDefault(x => x.CustomerNumber == name);
            view.ShowBalance(n.AccountBalance);
        }





    }
}
