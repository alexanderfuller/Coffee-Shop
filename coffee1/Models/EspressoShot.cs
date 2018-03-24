using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace coffee1.Models
{
    public class EspressoShot:CondimentDecorator
    {
        Beverage beverage;

        public EspressoShot(Beverage aBeverage)
        {
            this.beverage = aBeverage;
        }
        public override string GetDescription()
        {
            return "Espresso Shot " + beverage.GetDescription();
        }
        public override double GetCost()
        {
            return (1.00 + beverage.GetCost());
        }
    }
}