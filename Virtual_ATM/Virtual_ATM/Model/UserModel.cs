﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Virtual_ATM.Model
{
   public class User
    {
       public int Id { get; set; }
       public string Name { get; set; }
       public string Address { get; set; }
       public string Password { get; set; }
       public virtual Account Account { get; set; }
    }
}
