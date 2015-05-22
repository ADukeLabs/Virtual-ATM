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
        AccountModel acc = new AccountModel();
        UserModel user = new UserModel();
        Router router = new Router();
        AtmView view = new AtmView();
        AtmModel model = new AtmModel();

        public AtmController(string customernum)
        {
            customerNumber = customernum;
        }

        public void Access(string name, string password)
        {



            if (acc.CustomerNumber == name)
            {
                if (user.Password == password)
                {
                    view.Welcome(customerNumber);

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






        public void UserOptions()
        {

           
           
            int xx = 0;
            

            switch (Option)
            {
                case "1":
                    
                    model.Withdraw(customerNumber);
                    break;

                case "2":
                    model.Deposit(customerNumber);
                    break;
                    
                //case 3:
                //    model.
                
                
                
                
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
