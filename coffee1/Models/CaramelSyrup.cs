using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace coffee1.Models
{
    public class CaramelSyrup:CondimentDecorator
    {
        Beverage beverage;
        
        public CaramelSyrup(Beverage aBeverage)
        {
            this.beverage = aBeverage;
        }
        public override string GetDescription()
        {
            return "Caramel Syrup " + beverage.GetDescription();
        }
        public override double GetCost()
        {
         

                return (1.75 + beverage.GetCost());
           
        }
    }
}