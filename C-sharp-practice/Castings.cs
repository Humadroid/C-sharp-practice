using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_sharp_practice
{
    class Castings
    {
        public void TestCastings()
        {
            //Explicit conversions
            var a = 12;
            var b = (short)a;
            var c = (long)a;

            //we can use GetTypeCode to see the type for each variable
            //Console.WriteLine(a.GetTypeCode());  // Int32
            //Console.WriteLine(b.GetTypeCode());  // Int16
            //Console.WriteLine(c.GetTypeCode());  // Int64
        }
    }
}
