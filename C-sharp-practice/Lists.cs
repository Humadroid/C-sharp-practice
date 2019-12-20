using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_sharp_practice
{
    class Lists
    {
        public void TestLists()
        {
            var fruits = new List<string>();

            /*
             * Methods
             * 1) Add
             */
            fruits.Add("Cherry");
            fruits.Add("Banana");
            fruits.Add("Watermelon");
            foreach (var item in fruits)
            {
                //Console.WriteLine(item);
            }

            /*
             * AddRange
             */
            fruits.AddRange(new[] { "Orange", "Pineapple", "Plumb" });
            foreach(var item in fruits)
            {
                //Console.WriteLine(item);
            }

            /*
             * Remove
             */
            fruits.Remove("Plumb");
            foreach (var item in fruits)
            {
                //Console.WriteLine(item);
            }

            /*
             * RemoveAt
             */
            fruits.RemoveAt(4);
            foreach(var item in fruits)
            {
                //Console.WriteLine(item);
            }

            /*
             * Contains
             */
            if(fruits.Contains("Banana"))
            {
                //Console.WriteLine("Yes Banana is there in the list");
            }

            /*
             * IndexOf
             */
            var indexOf = fruits.IndexOf("Banana");
            //Console.WriteLine($"banana is available at {indexOf}");

            /*
             * Insert
             */
            fruits.Insert(2, "lemon");
            foreach(var item in fruits)
            {
                //Console.WriteLine(item);
            }

            /*
             * Count()
             */
            //Console.WriteLine(fruits.Count());

            //Count
            //Console.WriteLine(fruits.Count);

            /*
             * string.Join
             * Converts list to string
             */
            var listString = string.Join(", ", fruits);
            //Console.WriteLine(listString);

            /*
             * Split 
             * Converts comma seperated string to list
             */
            var list = listString.Split(',').ToList();
            foreach(var item in list)
            {
                //Console.WriteLine(item);
            }

            /*
             * Sort
             */
            fruits.Sort();
            foreach(var item in fruits)
            {
                //Console.WriteLine(item);
            }

            //Sort using IComparer 
            var laptops = new List<Laptop>
            {
                new Laptop("Macbook", 3000),
                new Laptop("Asus", 1500),
                new Laptop("HP", 1100)
            };

            laptops.Sort(new LaptopPriceComparer());
            foreach (var laptop in laptops)
            {
                //Console.WriteLine(laptop.Make);
            }

            //Sort with OrderBy
            var sortedLaptops = laptops.OrderBy(laptop => laptop.Price);
            //Console.WriteLine("Laptops Brands sorted based on Price");
            foreach (var laptop in sortedLaptops)
            {
                //Console.WriteLine(laptop.Make);
            }

            /*
             * Clear()
             * clears the list
             */
            fruits.Clear();
            if (fruits.Count > 0)
            {
                //Console.WriteLine("The various fruits are");
                foreach (var fruit in fruits)
                {
                    //Console.WriteLine(fruit);
                }
            } 
            else
            {
                //Console.WriteLine("The fruits list is cleared");
            }
        }

        public class Laptop
        {
            public string Make { get; set; }

            public double Price { get; set; }

            public Laptop(string make, double price)
            {
                Make = make;
                Price = price;
            }
        }

        public class LaptopPriceComparer : IComparer<Laptop>
        {
            public int Compare(Laptop x, Laptop y) => x.Price.CompareTo(y.Price);
        }
    }
}
