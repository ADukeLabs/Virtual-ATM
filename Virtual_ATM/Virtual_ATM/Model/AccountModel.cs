using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Virtual_ATM.Model
{
  public  class Account
    {
        public int Id { get; set; }
        public string CustomerNumber { get; set; }
        public string AccountNumber { get; set; }
        [Required]
        public virtual User User { get; set; }
        public decimal AccountBalance { get; set; }
    }
}
