using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Virtual_ATM.Model
{
  public  class AccountModel
    {
        public int Id { get; set; }
        public string CustomerNumber { get; set; }
        public string AccountNumber { get; set; }
       
        public decimal AccountBalance { get; set; }
    }
}
