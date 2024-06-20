using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern
{
    internal class Car : IVehicle
    {

        public int Wheels { get; set; } = 4;

        public void Drive()
        {
            Console.WriteLine("A car needs 4 wheels");
        }

    }



}
