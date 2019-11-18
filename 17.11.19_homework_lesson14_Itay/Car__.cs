using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace _17._11._19_homework_lesson14_Vehicles_Itay
{

    class Car__ : VehicleBase
    {
        private int _numberOfDoors;
        public int NumberOfDoors
        {
            get => _numberOfDoors;
            set
            {
                if (value < 2) { _numberOfDoors = 2; }
                else if (value > 2) { _numberOfDoors = 4; }
            }
        }


        public override int getMaximOfPassengers()
        {
            int numberOfPassengers = 4;
            switch(_numberOfDoors)
            {
                case 2: numberOfPassengers = 4; break;
                case 4: numberOfPassengers = 6; break;
            }
            return numberOfPassengers;
        }

        public Car__(int numberOfWheels, string model, int numberOfDoors) : base(numberOfWheels, model)
        {
            _numberOfDoors = numberOfDoors;
        }

        public override int getMaxSpeed()
        {
            int MaxSpeed = 4;
            switch (_numberOfDoors)
            {
                case 2: MaxSpeed = 130; break;
                case 4: MaxSpeed = 200; break;
            }
            return MaxSpeed;
        }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}
