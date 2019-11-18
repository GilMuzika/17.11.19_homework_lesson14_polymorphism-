using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _17._11._19_homework_lesson14_Vehicles_Itay
{
    class Motorcycle__ : VehicleBase
    {
        private int _numberOfHandBreaks;
        public int NumberOfHandBreaks
        {
            get => _numberOfHandBreaks; 
            set
            {
                if (value < 1) { _numberOfHandBreaks = 1; MessageBox.Show("Motorcycle must have at least one handbrake! The handbrakes number is set to 1"); }
                else if (value > 2) { _numberOfHandBreaks = 2; MessageBox.Show("Motorcycle can't have more than 2 handbrakes. The handbrakes number is set to 2"); }
            }
        }

        public Motorcycle__(int numberOfWheels, string model, int numberOfHandBreaks) : base(numberOfWheels, model)
        {
            _numberOfHandBreaks = numberOfHandBreaks;
        }


        public override int getMaximOfPassengers()
        {
            return _numberOfWheels;
        }

        public override int getMaxSpeed()
        {
            if (_numberOfHandBreaks < 1) throw new Exception("Motorcycle must have at least one handbrake!");
            if (_numberOfHandBreaks == 1) return 100;
            else return 180;
        }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}
