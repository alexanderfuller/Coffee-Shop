using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace coffee1.Models
{
    public class Vanilla : CondimentDecorator
    {
        Beverage beverage;

        public Vanilla(Beverage aBeverage)
        {
            this.beverage = aBeverage;
        }
        public override string GetDescription()
        {
            return "Vanilla " + beverage.GetDescription();
        }
        public override double GetCost()
        {
            return (1.00 + beverage.GetCost());
        }
    }
}