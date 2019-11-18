using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _17._11._19_homework_lesson14_Vehicles_Itay

{
    class Carrier
    {
        public List<VehicleWithTypeContainer> Vehicles = new List<VehicleWithTypeContainer>();


        public override string ToString()
        {
            string toreturn = string.Empty;
            foreach (var s in Vehicles) toreturn += s.VehicleItself.ToString() + Environment.NewLine;

            return toreturn;
        }


    }
}
