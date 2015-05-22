using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Virtual_ATM
{
    public class Router
    {
        public void Propmt()
        {
            Console.WriteLine("Hi and Welcome to the Bank of Roa's virtual ATM");
            Console.WriteLine("Please enter your Customer Number");
            string customerNum = Console.ReadLine();
            Console.WriteLine("Great! Now please enter your password.");
            string customerpass = Console.ReadLine();

            AtmController controller = new AtmController(customerNum);
            controller.Access(customerNum, customerpass);

        }
    }
}
