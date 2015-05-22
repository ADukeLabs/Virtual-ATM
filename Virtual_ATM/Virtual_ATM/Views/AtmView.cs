using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Virtual_ATM.Model
{
    public class AtmView
    {
        public void AsciiWelcome()
        {
            List<string> list = new List<string>();
            using (StreamReader reader = new StreamReader("welcomemessage.txt"))
            {
                string line;

                while ((line = reader.ReadLine()) != null)
                {
                    list.Add(line); 
                    Console.WriteLine(line); 
                }
            }
        }

        public void Welcome(string customerNumber)
        {
            Console.WriteLine("\nWelcome to roa {0}\n", customerNumber );
        }

        public void IncorrectPassword()
        {
            Console.WriteLine("Sorry, but that is a invalid password. Please try again.");
        }

        public void InvalidUserName()
        {
            Console.WriteLine("Sorry, but we have no record of that Username.");
        }

        public string UserOptions()
        {
            Console.WriteLine("Would you like to either : ");
            Console.WriteLine("1.Withdraw a sum");
            Console.WriteLine("2.Deposit a sum");
            Console.WriteLine("3.View your Balance");
            Console.WriteLine("4.Logoff");

            string usersOption = Console.ReadLine();
            return usersOption;
        }

        public void ShowBalance(decimal balance)
        {
            Console.WriteLine("\nYour current balance is: {0}\n", balance );
        }

        public void NOBalance()
        {
            Console.WriteLine("\nSorry, unfortunately you have insuffecient funds to make this transaction.");
        }
    }
}
