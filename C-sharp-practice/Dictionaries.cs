using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_sharp_practice
{
    class Dictionaries
    {
        public void TestDictionaries()
        {
            //A dictionary holds key-value pairs

            //create a dictionary 
            var store1 = new Dictionary<string, double>();

            //Adding Items
            store1.Add("peach", 4.5);
            store1.Add("lemon", 10);
            store1.Add("grape", 14.8);

            //Adding items using Object initializers
            var store2 = new Dictionary<string, double>
            {
                { "peach", 4.5 },
                { "lemon", 10 },
                { "grape", 14.8 }
            };

            //Adding items using index initializers
            var store3 = new Dictionary<string, double>
            {
                ["peach"] = 4.5,
                ["lemon"] = 10,
                ["grape"] = 14.8
            };

            /*
             * Dictionary Methods
             */
            var store = new Dictionary<string, double>
            {
                ["peach"] = 15,
                ["grape"] = 23,
                ["lemon"] = 8,
                ["coconut"] = 10
            };

            /*
             * Add
             */
            try
            {
                store.Add("peach", 21);
            }
            catch (ArgumentException)
            {

            }

            /*
             * ContainsKey
             */
            var key = "peach";
            if(store.ContainsKey(key)) 
            {
                //Console.WriteLine(store[key]);
            } 
            else
            {
                //Console.WriteLine($@"Key -> {key} doesn't exist.");
            }

            /*
             * Remove
             */
            store.Remove("coconut");

            /*
             * Count
             */
            var totalFruitTypes = store.Count;
            //Console.WriteLine(totalFruitTypes);

            /*
             * TryGetValue
             */
            store.TryGetValue("lemon", out double quantity);
            //Console.WriteLine(quantity);

            /*
             * Sorting
             * 1) Sorting by keys
             */
            var fruitStore = new Dictionary<string, double>
            {
                ["peach"] = 15,
                ["grape"] = 23,
                ["lemon"] = 8,
                ["coconut"] = 10
            };

            //We need to get the Keys into an array
            var sortedStoreByKey = fruitStore.Keys.ToArray();
            //Once we have the keys in an array, we can sort them
            Array.Sort(sortedStoreByKey);
            //Then, we display the store dictionary based on this array:
            foreach (var thekey in sortedStoreByKey)
            {
                //Console.WriteLine($"{thekey}: {fruitStore[thekey]}");
            }

            /*
             * 2) Sort by Values
             */
            var sortedStoreByValue = fruitStore.OrderBy(item => item.Value).Select(item => item.Key);
            //Then, we can display based on the Keys again
            foreach (var thekey in sortedStoreByValue)
            {
                //Console.WriteLine($"{thekey}: {fruitStore[thekey]}");
            }
        }
    }
}
