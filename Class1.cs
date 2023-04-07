using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    public class Class1
    {
        public string DriverName { get; set; }
        public string OnDuty { get; set; }
        public string NumberOfPassenger { get; set; }



        public void TaxiInfo()
        {
            Console.WriteLine("Driver Name : {0}", DriverName);
            Console.WriteLine("OnDuty : {0}", OnDuty);
            Console.WriteLine("Number Of Passenger : {0}", NumberOfPassenger);

        }

        public void PickUpPassenger()
        {
            Console.WriteLine("\n {0} Sedang menjemput penumpang", DriverName);
        }

        public void DropOffPassenger()
        {
            Console.WriteLine(" {0} Selesai menjemput penumpang", DriverName);
        }
    }
}
