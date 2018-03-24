using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace coffee1.Models
{
    public class Milk: CondimentDecorator
    {
        Beverage beverage;

        public Milk(Beverage aBeverage)
        {
            this.beverage = aBeverage;
        }
        public override string GetDescription()
        {
            return "Milk " + beverage.GetDescription();
        }
        public override double GetCost()
        {
            return (0.50 + beverage.GetCost());
        }
    }
}