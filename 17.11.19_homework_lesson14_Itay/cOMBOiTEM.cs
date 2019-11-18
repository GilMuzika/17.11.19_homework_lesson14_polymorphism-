using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _17._11._19_homework_lesson14_Vehicles_Itay
{
    class ComboItem
    {
        public string Value {get; private set;}
        public string AdditionalMessage { get; private set; }

        public ComboItem(string val, string additionalMessage)
        {
            Value = val; AdditionalMessage = additionalMessage;
        }

        public override string ToString()
        {
            return AdditionalMessage + " " + Value;
        }


    }
}
