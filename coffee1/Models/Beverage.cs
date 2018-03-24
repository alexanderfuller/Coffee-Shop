﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace coffee1.Models
{
    public abstract class Beverage
    {
        public string description = "Unknown Beverage";

        public virtual string GetDescription()
        {
            return description;
        }

        public abstract double GetCost();

       
     



    }
}
    
