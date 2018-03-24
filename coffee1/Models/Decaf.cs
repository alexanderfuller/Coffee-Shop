using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace coffee1.Models
{
    public class Decaf: Beverage
    {

        public Decaf()
        {

            this.description = "Decaf";
        }
        public override double GetCost()
        {
            return 1.00;
        }

    }
}