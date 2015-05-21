using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Virtual_ATM.Model
{
   public class UserModel
    {
       public int Id { get; set; }
       public string Name { get; set; }
       public string Address { get; set; }
       //public int Paygrade { get; set; }
       public virtual AccountModel CustomerNumber { get; set; }
    }
}
