using System;
using System.Reflection.Emit;
using UrbanPlanner;

namespace UrbanPlanner
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("--Urban Planner Assignment--");
            Console.WriteLine("\n");

            Building myFirstProperty = new Building("123 Main Street");
            myFirstProperty.Construct();
            myFirstProperty.Stories = 5;
            myFirstProperty.Width = 30;
            myFirstProperty.Depth = 25;
            myFirstProperty.Purchase("Jimbo Real Estate Holdings");


            Building mySecondProperty = new Building("456 West Bridge Road");
            mySecondProperty.Construct();
            mySecondProperty.Stories = 3;
            mySecondProperty.Width = 15;
            mySecondProperty.Depth = 20;
            mySecondProperty.Purchase("Mr. and Mrs. Smith");


            Building myThirdProperty = new Building("789 Scout Way");
            myThirdProperty.Construct();
            myThirdProperty.Stories = 10;
            myThirdProperty.Width = 150;
            myThirdProperty.Depth = 200;
            myThirdProperty.Purchase("VS Group, LLC.");
        }
    }
}
