using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace coffee1.Models
{
    public class Soy : CondimentDecorator
    {
        Beverage beverage;

        public Soy(Beverage aBeverage)
        {
            this.beverage = aBeverage;
        }
        public override string GetDescription()
        {
            return "Soy " + beverage.GetDescription();
        }
        public override double GetCost()
        {
            return (1.00 + beverage.GetCost());
        }
    }
}