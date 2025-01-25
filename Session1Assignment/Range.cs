using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Session1Assignment
{
    public class Range<T> where T : INumber<T>
    {
        public T Min { get; private set; }
        public T Max { get; private set; }

        public Range(T min, T max)
        {
            Min = min;
            Max = max;
        }

        public bool IsInRange(T value)
        {
            return value >= Min && value <= Max;
        }

        public T Length()
        {
            return Max - Min;
        }
    }
}
