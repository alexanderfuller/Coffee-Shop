using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace coffee1.Models
{
    public abstract class CondimentDecorator:Beverage
    {
        // The upshot of this class is that 
        // Addons are considered a separate thing
        // from a "regular" beverage
        // this is, you cannot buy a cup of
        // pumpkin spice espresso shot mocha mocha whip
    }
}