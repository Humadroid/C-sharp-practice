using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_sharp_practice
{
    class Arrays
    {
        public void TestArrays()
        {
            /*
             * Arrays are immutable
             * 
             * Array.Resize
             * Resize method creates a new array in the background and reassigns it to the initial array. 
             * So, it's not changing the array
             */
            var array1 = new byte[10];
            //Console.WriteLine("Array1 length is {0}", array1.Length);
            var array2 = array1;
            Array.Resize<byte>(ref array1, 20);
            //Console.WriteLine("New Array1 length is {0}", array1.Length);
            //Console.WriteLine("New Array2 length is {0}", array2.Length);

            /*
             * Length
             * You can find how many items are in an array by accessing its Length property
             */
            var fruits = new string[] { "watermelon", "peach", "lemon" };
            var length = fruits.Length;
            //Console.WriteLine(length);

            /*
             * Count()
             * The array exposes the Count() method as well, 
             * but the Length property is faster, so consider using it over the method.
             */
            var count = fruits.Count();
            //Console.WriteLine(count);

            /*
             * for loop
             */
            for (int i = 0; i < fruits.Length; i++)
            {
                //Console.WriteLine(fruits[i]);
            }

            /*
             * foreach loop
             */
            foreach (var fruit in fruits)
            {
                //Console.WriteLine(fruit);
            }

            /*
             * Array Methods
             * 
             * 1) IndexOf
             * This returns the index of an item inside the array
             */
            var indexOf = Array.IndexOf(fruits, "lemon");
            //Console.WriteLine(indexOf);

            /*
             * Exists
             * It checks to see whether or not an item exists in an array (this accepts a Predicate)
             * Returns boolean
             */
            var exists = Array.Exists(fruits, fruit => fruit.Contains("lemon"));
            //Console.WriteLine(exists);

            /*
             * Find
             * This simply finds an item in an array (this accepts a Predicate)
             * Returns the first item that contains the element we search for
             */
            var find = Array.Find(fruits, fruit => fruit.Contains("l"));
            //Console.WriteLine(find);

            /*
             * FindLast
             * As the Find method, but this starts from the end of the array
             */
            var findLast = Array.FindLast(fruits, fruit => fruit.Contains("l"));
            //Console.WriteLine(findLast);

            /*
             * FindIndex
             * We can also find the index of an item by using a Predicate
             */
            var findIndex = Array.FindIndex(fruits, fruit => fruit.Contains("l"));
            //Console.WriteLine(findIndex);

            /*
             * FindAll
             * We can find all the items that pass a certain condition:
             */
            var result = Array.FindAll(fruits, fruit => fruit.Contains("l"));
            foreach (var fruit in result)
            {
                //Console.WriteLine(fruit);
            }

            /*
             * Reverse
             * We can Reverse the items in an array
             */
            Array.Reverse(fruits);
            foreach (var fruit in fruits)
            {
                //Console.WriteLine(fruit);
            }

            /*
             * Copy
             * We can copy the items of an array to another one
             */
            var fruits2 = new string[fruits.Length];
            Array.Copy(fruits, fruits2, fruits2.Length);
            foreach (var fruit in fruits2)
            {
                //Console.WriteLine(fruit);
            }

            /*
             * Sort
             * Sorts the array
             */
            Array.Sort(fruits);
            foreach (var fruit in fruits)
            {
                //Console.WriteLine(fruit);
            }

            /*
             * Reverse sort Array
             * Array.Reverse(array)
             */
            Array.Sort(fruits);
            Array.Reverse(fruits);
            foreach (var fruit in fruits)
            {
                //Console.WriteLine(fruit);
            }

            /*
             * Reverse sort using IComparer Interface
             */
            Array.Sort(fruits, new ReverseComparer());
            foreach (var fruit in fruits)
            {
               //Console.WriteLine(fruit);
            }

            /*
             * Binary Search
             * search for an element in a sorted array 
             * (make sure to sort the array in ascending order before applying this algorithm)
             */
            Array.Sort(fruits);
            var index = Array.BinarySearch(fruits, "coconut");
            if (index == -1)
            {
                //Console.WriteLine("nothing");
            }
            else
            {
                //Console.WriteLine(index);
            }



        }

        public class ReverseComparer : IComparer<String>
        {
            public int Compare(string x, string y)
            {
                return y.CompareTo(x);
            }
        }
    }
}
