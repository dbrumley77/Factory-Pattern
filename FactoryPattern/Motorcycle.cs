using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern
{
    internal class Motorcycle : IVehicle
    {

        public int Wheels { get; set; } = 2;

        public void Drive()
        {
            Console.WriteLine("A motorcycle needs 2 wheels");
        }


    }




}
