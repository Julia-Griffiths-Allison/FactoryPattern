using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory_Pattern
{
    internal class VehicleFactory
    {
        public static IVehicle GetVehicle(string answer)
        {
            switch (answer.ToLower())
            {
                case "two":
                    return new Car();
                case "2":
                     return new Car();
                case "four":
                    return new Motorcycle();
                case "4":
                    return new Motorcycle();
                default:
                    return new Car();
            }
        }
    }
}
