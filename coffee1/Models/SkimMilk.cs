using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace coffee1.Models
{
    public class SkimMilk : CondimentDecorator
    {
        Beverage beverage;

        public SkimMilk(Beverage aBeverage)
        {
            this.beverage = aBeverage;
        }
        public override string GetDescription()
        {
            return "Skim Milk " + beverage.GetDescription();
        }
        public override double GetCost()
        {
            return (2.00 + beverage.GetCost());
        }
    }
}