using ConsoleApp2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Taxi
{
    class Program
    {
        static void Main(string[] args)
        {
            Class1 taxi = new Class1();

            taxi.DriverName = "Wowi";
            taxi.OnDuty = "Yes";
            taxi.NumberOfPassenger = "10";

            taxi.TaxiInfo();
            taxi.PickUpPassenger();
            taxi.DropOffPassenger();    

            Console.ReadKey();


        }
    }
}

