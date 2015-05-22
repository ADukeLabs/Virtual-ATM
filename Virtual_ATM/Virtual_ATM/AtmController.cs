using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Virtual_ATM.Model;

namespace Virtual_ATM
{
    public class AtmController
    {
        public string customerNumber { get; set; }
        public string Option { get; set; }
        AtmDBcontext db = new AtmDBcontext();
        Account acc = new Account();
        User user = new User();
        Router router = new Router();
        AtmView view = new AtmView();
        AtmModel model = new AtmModel();

        public AtmController(string customernum)
        {
            customerNumber = customernum;
        }

        public void Access(string name, string password)
        {
            var table = db.Accounts.FirstOrDefault(x => x.CustomerNumber == name);
            var utable = db.Users.FirstOrDefault(x => x.Password == password);
            if (table.CustomerNumber == name)
            {
                if (utable.Password == password)
                {

                    view.Welcome(customerNumber);
                    string OP = view.UserOptions();
                    UserOptions(OP);
                }
                else
                {
                    view.IncorrectPassword();
                    router.Propmt();
                }
            }

            else
            {
                view.InvalidUserName();
            }
             Option = view.UserOptions();
        }






        public void UserOptions(string Option)
        {

           
           
            int xx = 0;
            

            switch (Option)
            {
                case "1":
                    
                    model.Withdraw(customerNumber);
                     string OP = view.UserOptions();
                    UserOptions(OP);
                    break;

                case "2":
                    model.Deposit(customerNumber);
                      string OPP = view.UserOptions();
                    UserOptions(OPP);
                    break;
                    
                case "3":
                    model.Display(customerNumber);
                    break;

                
                
                
                
                case "4":
                    Console.Clear();
                  router.Propmt();
                    break;

                //case 4:
                //    model.Create();
                //    break;


                default :
                    Console.WriteLine("Please choose correct corresponding number.");
                    break;


            }



        }

       



    }
}
