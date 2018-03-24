using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using coffee1.Models;

namespace coffee1.Controllers
{
    public class HomeController : Controller
    {
        //
        // GET: /Home/


        public ActionResult Index()
        {

            return View();
        }

                              
        
        //Below is used to get the int value for X amounts the user selects for the condiments
        public ActionResult display(string Coffee, int? Decorator1, int? Decorator2, int? Decorator3, int? Decorator4, int? Decorator5, int? Decorator6, int? Decorator7, int? Decorator8, int? Decorator9, int? Decorator10)
        {

            //assign base coffees different orders
            CoffeeNull anOrder0 = new CoffeeNull();
            ViennaRoast anOrder = new ViennaRoast();
            Espresso anOrder2 = new Espresso();
            Columbian anOrder3 = new Columbian();
            Decaf anOrder4 = new Decaf();
            FrenchRoast anOrder5 = new FrenchRoast();

            //gets price of condiment under an empty order so you just get condiments price
            PumpkinSpice addon1 = new PumpkinSpice(anOrder0);
            Milk addon2 = new Milk(anOrder0);
            Soy addon3 = new Soy(anOrder0);
            CaramelSyrup addon4 = new CaramelSyrup(anOrder0);
            EspressoShot addon5 = new EspressoShot(anOrder0);
            Mocha addon6 = new Mocha(anOrder0);
            SkimMilk addon7 = new SkimMilk(anOrder0);
            Vanilla addon8 = new Vanilla(anOrder0);
            WhipCream addon9 = new WhipCream(anOrder0);
            Cinnamon addon10 = new Cinnamon(anOrder0);
           

            //declare condiments
            double price = 0;
            double pumpkinSpice = 0;
            double milk = 0;
            double soy = 0;
            double cinnamon = 0;
            double whipcream = 0;
            double vanilla = 0;
            double skimmilk = 0;
            double caramelsyrup = 0;
            double espressoshot = 0;
            double mocha = 0;

            //declare condiments variable description
            string spumpkinSpice = "";
            string smilk = "";
            string ssoy = "";
            string svanilla = "";
            string swhipcream = "";
            string sespressoshot = "";
            string smocha = "";
            string scaramelsyrup = "";
            string sskimmilk= "";
            string scinnamon = "";

            //convert users  input numbers for X amounts of condiments to variables we can use here
            int decorator1 = Decorator1 ?? default(int);
            int decorator2 = Decorator2 ?? default(int);
            int decorator3 = Decorator3 ?? default(int);
            int decorator4  = Decorator4 ?? default(int);
            int decorator5  = Decorator5 ?? default(int);
            int decorator6  = Decorator6 ?? default(int);
            int decorator7  = Decorator7 ?? default(int);
            int decorator8  = Decorator8 ?? default(int);
            int decorator9 = Decorator9??  default(int);
            int decorator10 = Decorator10 ?? default(int);


            //gets the cost of the condiment if it is selected * X amount and a Coffee is checked
            if (decorator1 > 0 && Coffee == "FrenchRoast" || Coffee == "ViennaRoast" || Coffee == "Espresso" || Coffee == "Columbian" || Coffee == "Decaf")
            {

                pumpkinSpice = addon1.GetCost() * decorator1;
                price = anOrder.GetCost() + pumpkinSpice + milk + soy + mocha + espressoshot + vanilla + skimmilk + whipcream + cinnamon + caramelsyrup;

                //repeats the string in qoutes based on users input amount
                spumpkinSpice = String.Concat(Enumerable.Repeat("PumpkinSpice ", decorator1));
            }
            


        
            if (decorator2 > 0 && Coffee == "ViennaRoast" || decorator2 > 0 && Coffee == "FrenchRoast" || decorator2 > 0 && Coffee == "Espresso" || decorator2 > 0 && Coffee == "Columbian" || decorator2 > 0 && Coffee == "Decaf")
            {

              
                milk = addon2.GetCost() * decorator2;
                price = anOrder.GetCost() + pumpkinSpice  + milk + soy + mocha + espressoshot + vanilla + skimmilk + whipcream + cinnamon + caramelsyrup;
                
                smilk = String.Concat(Enumerable.Repeat("Milk ", decorator2));

            }
          
            if (decorator3 > 0 && Coffee == "ViennaRoast" || decorator3 > 0 && Coffee == "FrenchRoast" || decorator3 > 0 && Coffee == "Espresso" || decorator3 > 0 && Coffee == "Columbian" || decorator3 > 0 && Coffee == "Decaf")
            {
           
                soy = addon3.GetCost() * decorator3;
                price = anOrder.GetCost() + pumpkinSpice + milk + soy + mocha + espressoshot + vanilla + skimmilk + whipcream + cinnamon + caramelsyrup;
           
                ssoy = String.Concat(Enumerable.Repeat("Soy ", decorator3));

            }
          

            if (decorator4 > 0 && Coffee == "ViennaRoast" || decorator4 > 0 && Coffee == "FrenchRoast" || decorator4 > 0 && Coffee == "Espresso" || decorator4 > 0 && Coffee == "Columbian" || decorator4 > 0 && Coffee == "Decaf")
            {

                caramelsyrup = addon4.GetCost() * decorator4;
                price = anOrder.GetCost() + pumpkinSpice + milk + soy + mocha + espressoshot + vanilla + skimmilk + whipcream + cinnamon + caramelsyrup;
         
                scaramelsyrup = String.Concat(Enumerable.Repeat("CaramelSyrup ", decorator4));

            }
          

            if (decorator5 > 0 && Coffee == "ViennaRoast" || decorator5 > 0 && Coffee == "FrenchRoast" || decorator5 > 0 && Coffee == "Espresso" || decorator5 > 0 && Coffee == "Columbian" || decorator5 > 0 && Coffee == "Decaf")
            {

                espressoshot = addon5.GetCost() * decorator5;
                price = anOrder.GetCost() + pumpkinSpice + milk + soy + mocha + espressoshot + vanilla + skimmilk + whipcream + cinnamon + caramelsyrup;
              
                sespressoshot = String.Concat(Enumerable.Repeat("EspressoShot ", decorator5));

            }
           


            if (decorator6 > 0 && Coffee == "ViennaRoast" || decorator6 > 0 && Coffee == "FrenchRoast" || decorator6 > 0 && Coffee == "Espresso" || decorator6 > 0 && Coffee == "Columbian" || decorator6 > 0 && Coffee == "Decaf")
            {
       
                mocha = addon6.GetCost() * decorator6;
                price = anOrder.GetCost() + pumpkinSpice + milk + soy + mocha + espressoshot + vanilla + skimmilk + whipcream + cinnamon + caramelsyrup;
            
                smocha = String.Concat(Enumerable.Repeat("Mocha ", decorator6));

            }
            

            if (decorator7 > 0 && Coffee == "ViennaRoast" || decorator7 > 0 && Coffee == "FrenchRoast" || decorator7 > 0 && Coffee == "Espresso" || decorator7 > 0 && Coffee == "Columbian" || decorator7 > 0 && Coffee == "Decaf")
            {

                skimmilk = addon7.GetCost() * decorator7;
                price = anOrder.GetCost() + pumpkinSpice + milk + soy + mocha + espressoshot + vanilla + skimmilk + whipcream + cinnamon + caramelsyrup;
            
                sskimmilk = String.Concat(Enumerable.Repeat("SkimMilk ", decorator7));

            }
           

            if (decorator8 > 0 && Coffee == "ViennaRoast" || decorator8 > 0 && Coffee == "FrenchRoast" || decorator8 > 0 && Coffee == "Espresso" || decorator8 > 0 && Coffee == "Columbian" || decorator8 > 0 && Coffee == "Decaf")
            {
           
                vanilla = addon8.GetCost() * decorator8;
                price = anOrder.GetCost() + pumpkinSpice + milk + soy + mocha + espressoshot + vanilla + skimmilk + whipcream + cinnamon + caramelsyrup;
              
                svanilla = String.Concat(Enumerable.Repeat("Vanilla ", decorator8));

            }
            

            if (decorator9 > 0 && Coffee == "ViennaRoast" || decorator9 > 0 && Coffee == "FrenchRoast" || decorator9 > 0 && Coffee == "Espresso" || decorator9 > 0 && Coffee == "Columbian" || decorator9 > 0 && Coffee == "Decaf")
            {
        
                whipcream = addon9.GetCost() * decorator9;
                price = anOrder.GetCost() +pumpkinSpice  + milk + soy + mocha + espressoshot + vanilla + skimmilk + whipcream + cinnamon + caramelsyrup;
            
                swhipcream = String.Concat(Enumerable.Repeat("WhipCream ", decorator9));

            }
            
            if (decorator10 > 0 && Coffee == "ViennaRoast" || decorator10 > 0 && Coffee == "FrenchRoast" || decorator10 > 0 && Coffee == "Espresso" || decorator10 > 0 && Coffee == "Columbian" || decorator10 > 0 && Coffee == "Decaf")
            {

                cinnamon = addon10.GetCost() * decorator10;
                price = anOrder.GetCost() + pumpkinSpice + milk + soy + mocha + espressoshot + vanilla + skimmilk + whipcream + cinnamon + caramelsyrup;
         
                scinnamon = String.Concat(Enumerable.Repeat("Cinnamon ", decorator10));

            }
           

            
         
            //display for if coffee is selected without any addons
            if (decorator1 == 0 && decorator2 == 0 && decorator3 == 0 && decorator4 == 0 && decorator5 == 0 && decorator6 == 0 && decorator7 == 0 && decorator8 == 0 && decorator9 == 0 && decorator10 == 0 )
            {
               price = anOrder.GetCost();
            }
          
            //declare viewbags to display data
            ViewBag.CofeeNull = anOrder0;
            ViewBag.ViennaRoast = anOrder;
            ViewBag.espresso = anOrder2;
            ViewBag.columbian = anOrder3;
            ViewBag.Decaf = anOrder4;
            ViewBag.FrenchRoast = anOrder5;


            ViewBag.price = price;
            ViewBag.pumpkinSpice = spumpkinSpice;
            ViewBag.milk = smilk;
            ViewBag.soy = ssoy;
            ViewBag.caramelsyrup = scaramelsyrup;
            ViewBag.espressoshot = sespressoshot;
            ViewBag.mocha = smocha;
            ViewBag.skimMilk = sskimmilk;
            ViewBag.vanilla = svanilla;
            ViewBag.whipcream = swhipcream;
            ViewBag.cinnamon = scinnamon;


            //if coffee is selected, return its name, and not all coffee names
            if (Coffee == "Columbian")
            {

                ViewBag.columbian = anOrder3;
            }
            else
            {
                ViewBag.columbian = anOrder0;
            }
            if (Coffee == "Decaf")
            {
                ViewBag.Decaf = anOrder4;
            }
            else
            {
                ViewBag.Decaf = anOrder0;
            }
            if (Coffee == "Espresso")
            {
               
                ViewBag.espresso = anOrder2;
          
            }
            else
            {
                ViewBag.espresso = anOrder0;
            }
            if (Coffee == "FrenchRoast")
            {
                ViewBag.FrenchRoast = anOrder5;
            }
            else
            {
                ViewBag.FrenchRoast = anOrder0;
            }
            if (Coffee == "ViennaRoast")
            {
               
                ViewBag.ViennaRoast = anOrder;
             
            }
            else
            {
                ViewBag.ViennaRoast = anOrder0;
            }


            return View();
        }


       
      
    }
}
