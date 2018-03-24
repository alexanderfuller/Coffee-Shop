using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace coffee1.Models
{
    public class Espresso:Beverage
    {

        public Espresso()
        {

            this.description = "Espresso";
        }
        public override double GetCost()
        {
            return 1.00;
        }

    }
}