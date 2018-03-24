using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace coffee1.Models
{
    public class PumpkinSpice : CondimentDecorator
    {
        Beverage beverage;

        public PumpkinSpice(Beverage aBeverage)
        {
            this.beverage = aBeverage;
        }
        public override string GetDescription()
        {
            return "Pumpkin Spice " + beverage.GetDescription();
        }
        public override double GetCost()
        {
            return (1.00 + beverage.GetCost());
        }
    }
}