using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace coffee1.Models
{
    public class FrenchRoast:Beverage
    {

        public FrenchRoast()
        {

            this.description = "FrenchRoast";
        }

        public override double GetCost()
        {
            return 1.00;
        }


    }
}