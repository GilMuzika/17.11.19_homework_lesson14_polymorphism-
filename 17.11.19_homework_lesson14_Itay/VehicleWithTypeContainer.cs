using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _17._11._19_homework_lesson14_Vehicles_Itay
{
    class VehicleWithTypeContainer
    {
        public Type VehicleType { get; private set; }
        public VehicleBase VehicleItself { get; private set; }

        public VehicleWithTypeContainer(Type type, VehicleBase vehicle)
        {
            VehicleType = type; VehicleItself = vehicle;
        }

        public override string ToString()
        {

            string vehicleNameWithPath = this.VehicleType.ToString().Replace("__", "");

              return $"{vehicleNameWithPath.Substring(vehicleNameWithPath.LastIndexOf(".")+1, vehicleNameWithPath.Length - (vehicleNameWithPath.LastIndexOf(".")+1))}: {this.VehicleItself._model}";
        }

    }
}
