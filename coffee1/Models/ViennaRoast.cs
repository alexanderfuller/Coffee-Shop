using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace coffee1.Models
{
    public class ViennaRoast:Beverage
    {

        public ViennaRoast()
        {

            this.description = "ViennaRoast";
        }

        public override double GetCost()
        {
            return 1.00;
        }
    }
}