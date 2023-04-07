using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LatihanTaxi
{
    internal class Class1
    {
        public string DriverName { get; set; }
        public bool OnDuty { get; set; }
        public int NumberOfPassenger { get; set; }

        public void TaxiInfo()
        {
            Console.WriteLine("Nama Driver : {0}", DriverName);
            if (OnDuty == true)
            {
                Console.WriteLine("On duty : Yes");
            }
            if (OnDuty == false)
            {
                Console.WriteLine("On Duty : No");
            }
            Console.WriteLine("Number of Passenger : {0}", NumberOfPassenger);
        }
        public void PickUpPassenger()
        {

            Console.WriteLine("{0} sedang menjemput penumpang", DriverName);

        }
        public void DropOffPassenger()
        {

            Console.WriteLine("{0} selesai mengantar penumpang", DriverName);

        }
    }
}
