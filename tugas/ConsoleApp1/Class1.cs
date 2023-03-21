using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tugas
{
  
        public class Taxi
        {
            public string DriverName { get; set; }
            public bool OnDuty { get; set; }
            public int NumPassanger { get; set; }

            public void TaxiInfo()
            {
                Console.WriteLine("Drive Name: {0}", DriverName);
                if (OnDuty == true)
                {
                    Console.WriteLine("On Duty : Yes");
                }
                else if (OnDuty == false)
                {
                    Console.WriteLine("On Duty: No");
                }
                Console.WriteLine("Number Of Passanger: {0}", NumPassanger);
            }
            public void PickUpPassanger()
            {
                Console.WriteLine("\nArya sedang menjemput penumpang");
            }
            public void DropOffPassanger()
            {
                Console.WriteLine("Arya selesai mengantar penumpang");
            }
        }
}
