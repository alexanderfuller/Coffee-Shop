using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace coffee1.Models
{
    public class CoffeeNull:Beverage
    {
        public CoffeeNull()
        {

            this.description = "";
        }

        public override double GetCost()
        {
            return 0;
        }
    }
}