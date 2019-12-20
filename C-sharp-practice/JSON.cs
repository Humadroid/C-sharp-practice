using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_sharp_practice
{
    class JSON
    {
        public void TestJSON()
        {
            //We need to install a NuGet package called: Newtonsoft.Json

            var phone = new Phone
            {
                Manufacturer = "Apple",
                Model = "iPhone X",
                Price = 1200.00
            };

            var phoneAsJsonString = JsonConvert.SerializeObject(phone);
            //Console.WriteLine($"The JSON below is unindented \n{phoneAsJsonString}\n");

            //We have the option to indent the code to be displayed more nicely
            var phoneAsJsonStringIndented = JsonConvert.SerializeObject(phone, Formatting.Indented);
            //Console.WriteLine($"The JSON below is indented \n{phoneAsJsonStringIndented}");
        }
    }

    internal class Phone
    {
        public string Manufacturer { get; set; }
        public string Model { get; set; }
        public double Price { get; set; }
    }
}
