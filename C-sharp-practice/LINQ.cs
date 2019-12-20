using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_sharp_practice
{
    class LINQ
    {
        public void TestLINQ()
        {
            /*
             * Range
             * We can generate numbers with the Range method
             */
            var range = Enumerable.Range(0, 8);
            foreach(var number in range)
            {
                //Console.WriteLine(number);
            }

            /*
             * Take
             * returns a specified number of elements from the start of a collection
             * Not memory efficient
             */
            var numbers = new List<int> { 2, 32, 11, 1, 24, 7 };
            var top = 3;
            var firstNumbers = numbers.Take(top);
            foreach(var number in firstNumbers)
            {
                //Console.WriteLine(number);
            }

            /*
             * RemoveAt
             * returns a specified number of elements from the start of a collection
             */
            while (numbers.Count != top)
            {
                numbers.RemoveAt(top);
            }
            foreach (var number in numbers)
            {
                //Console.WriteLine(number);
            }

            /*
             * Where
             * It filters a collection based on a predicate 
             * A predicate is a function that tests each element of a collection based on a condition and returns true or false.
             */
            var theNumbers = new List<int> { 2, 32, 11, 1, 24, 7 };
            var evenNumbers = theNumbers.Where(number => number % 2 == 0);
            foreach (var number in evenNumbers)
            {
                //Console.WriteLine(number);
            }

            //Where method can also accept a second parameter which represents the index of that current element.
            var evenNumbersAtEvenPositions = numbers.Where((number, index) => number % 2 == 0 && index % 2 == 0);
            foreach (var number in evenNumbersAtEvenPositions)
            {
                //Console.WriteLine(number);
            }
        }
    }
}
