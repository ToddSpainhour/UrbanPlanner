using System;
using System.Collections.Generic;
using System.Text;

namespace UrbanPlanner
{
    class Building
    {

   

        //fields

        private string _designer = "Todd Spainhour";
        private DateTime _dateConstructed;
        private string _address = "";
        private string _owner = "";




        //properties

        public int Stories = 3;
        public double Width;
        public double Depth;
        public double Volume
        {
            get
            {
                return Width * Depth * (3 * Stories);
            }
        }




        //constructors

        public Building(string address)
        {
            _address = address;
        }



        //methods


        public void Construct()
        {
            _dateConstructed = DateTime.Now;
        }



        public void Purchase(string _owner)
        {
            Console.WriteLine("---------------------");
            Console.WriteLine($"Address: {_address}");
            Console.WriteLine($"Designed by: {_designer}");
            Console.WriteLine($"Constructed on: {_dateConstructed}");
            Console.WriteLine($"Owned by: {_owner}");
            Console.WriteLine($"Cubic Meters: {Volume}");
            Console.WriteLine("\n");
        }
    }
}
