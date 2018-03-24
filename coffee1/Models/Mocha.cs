using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace coffee1.Models
{
    public class Mocha : CondimentDecorator
    {
        Beverage beverage;

        public Mocha(Beverage aBeverage)
        {
            this.beverage = aBeverage;
        }
        public override string GetDescription()
        {
            return "Mocha " + beverage.GetDescription();
        }
        public override double GetCost()
        {
            return (1.00 + beverage.GetCost());
        }
    }
}