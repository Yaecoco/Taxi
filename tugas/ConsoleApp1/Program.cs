using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tugas
{
    class Program
    {
        static void Main(string[] args)
        {
            // membuat objek Taxi
            Taxi taxi= new Taxi();

            // pengertian nilai properties
            taxi.DriverName = "Arya";
            taxi.OnDuty = true;
            taxi.NumPassanger = 9;

            // pemanggil method
            taxi.TaxiInfo();
            taxi.PickUpPassanger();
            taxi.DropOffPassanger();

            Console.ReadKey();
        }
    }
}
    