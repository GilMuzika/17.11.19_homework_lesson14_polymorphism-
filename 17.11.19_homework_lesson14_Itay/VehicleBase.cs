using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace _17._11._19_homework_lesson14_Vehicles_Itay
{
    abstract class VehicleBase
    {
        public string _model;
        public int _numberOfWheels;        

        public VehicleBase(int numberOfWheels, string model)
        {
            _numberOfWheels = numberOfWheels; _model = model;
        }

        abstract public int getMaximOfPassengers();
        abstract public int getMaxSpeed();


        public override string ToString()
        {
            FieldInfo[] fieldsinfo = this.GetType().GetFields(BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.Instance);
            MethodInfo[] methodsinfo = this.GetType().GetMethods(BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.Instance);

            string fields = string.Join("", fieldsinfo.inverseArray().Select(x => $"{x.Name}: {x.GetValue(this)}\n"));            
            string methods = string.Join("", methodsinfo.Where(x => ((Func<bool>)(() => { return x.Name.IndexOf("getMaxS", 0, x.Name.Length, StringComparison.CurrentCultureIgnoreCase) != -1; }))()).Select(x => $"{x.Name.Replace("get", "")}: {x.Invoke(this, null)} Km/H\n"));

            return fields + methods;
        }


















    }
}


