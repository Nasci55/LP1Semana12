using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HowManyOfThisType
{
    public static class Checker
    {
        public static int HowManyOfThisType<T>(IEnumerable<object> items)
        {
            int howMany = 0;
            foreach (object type in items)
            {
                if (type is T)
                {
                    howMany++;
                }
            }

            return howMany;
        }
    }
}