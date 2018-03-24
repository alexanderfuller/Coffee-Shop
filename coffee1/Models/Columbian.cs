using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace coffee1.Models
{
    public class Columbian:Beverage
    {
        public Columbian()
        {
            this.description = "Columbian";
        }


        public override double GetCost()
        {
            return 1.00;
        }
    }
}