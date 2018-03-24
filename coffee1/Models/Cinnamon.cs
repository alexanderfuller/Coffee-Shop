using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace coffee1.Models
{
    public class Cinnamon : CondimentDecorator
    {
        Beverage beverage;

        public Cinnamon(Beverage aBeverage)
        {
            this.beverage = aBeverage;
        }
        public override string GetDescription()
        {
            return "Cinnamon " + beverage.GetDescription();
        }
        public override double GetCost()
        {
            return (0.25 + beverage.GetCost());
        }
    }
}