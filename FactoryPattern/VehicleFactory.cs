using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern
{
    static class VehicleFactory
    {

        public static IVehicle GetVehicle(int userInput)
        {

            if (userInput == 2)
            {
                Console.WriteLine("Making a new Motorcycle");
                return new Motorcycle();
            }
            else if (userInput == 4)
            {
                Console.WriteLine("Making a new Car");
                return new Car();
            }
            return new Car();
             
            

        }

    }




}
