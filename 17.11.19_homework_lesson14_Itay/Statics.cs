using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _17._11._19_homework_lesson14_Vehicles_Itay
{
    static class Statics
    {
        public static IEnumerable<T> inverseArray<T>(this IList<T> array)
        {
            List<T> newCollection = new List<T>();
            for (int i = array.Count - 1; i >= 0; i--)
            {
                newCollection.Add(array[i]);
            }

            return newCollection;
        }
    }
}
