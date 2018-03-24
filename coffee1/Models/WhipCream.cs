using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace coffee1.Models
{
    public class WhipCream : CondimentDecorator
    {
        Beverage beverage;

        public WhipCream(Beverage aBeverage)
        {
            this.beverage = aBeverage;
        }
        public override string GetDescription()
        {
            return "Whip Cream " + beverage.GetDescription();
        }
        public override double GetCost()
        {
            return (3.00 + beverage.GetCost());
        }
    }
}