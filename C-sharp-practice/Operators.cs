using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_sharp_practice
{
    class Operators
    {
        public void TestOperators()
        {
            /*
             * is Operator
             * This operator evaluates the type of a variable (type compatibilty)
             */
            var color = "red";
            if(color is string)
            {
                //Console.WriteLine($"color: {color} is of string type");
            }

            /*
             * increment and decrement operators
             */
            var number = 1;
            //Console.WriteLine(number);   // 1
            //Console.WriteLine(number++); // 1 post-increment increments on next usage
            //Console.WriteLine(++number); // 3 pre-increment increments at the same place

            //Console.WriteLine(--number); // 2 pre-decrement decrements at the same place
            //Console.WriteLine(number--); // 2 post-decrement decrements on next usage
            //Console.WriteLine(number);   // 1 

            /*
             * && and || short-circuiting logical operators
             */
        }
    }
}
