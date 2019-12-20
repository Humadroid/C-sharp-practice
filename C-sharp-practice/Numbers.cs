using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_sharp_practice
{
    class Numbers
    {
        public void TestNumbers()
        {
            var number = 43; //integer
            
            var floatNumber = 12F;  // float
            var doubleNumber1 = 23D; // double
            var doubleNumber2 = 12.34; //double
            var decimalNumber = 5M; // decimal
            var longNumber = 12L;   // long
            
            //For integers, we can can unsigned numbers when we don't care about negative numbers and we want only positive ones:
            var unsignedNumber = 12U;

            //the max value for unsigned should be double the max one for all ints
            var maxInt = int.MaxValue;
            var maxIntUnsigned = UInt32.MaxValue;
            //Console.WriteLine(maxIntUnsigned > maxInt * 2); // True

            //To check if a value if not a number
            var number2 = double.NaN;
            var result = double.IsNaN(number2);
            //Console.WriteLine(result); // True

            //Overflowing
            //We can get the maximum value of an integer
            var maxValue = int.MaxValue;
            //Console.WriteLine(maxValue); // 2147483647

            //If we increment this value, then the maxValue get the minumum value
            maxValue++;
            //Console.WriteLine(maxValue); // -2147483648 this doesn't throw exception, its called Integral Overflow

            //If you want to throw exceptions when this happens, you can use checked
            //The checked operator cannot be applied for double, float and decimal
            checked
            {
                maxValue++;
                //Console.WriteLine(maxValue);
            }


        }
    }
}
