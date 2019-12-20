using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_sharp_practice
{
    class Strings
    {
        public void TestStrings()
        {
            /* 
             * Strings are immutable
             * 
             * String Interpolation
             * 1) string.Format
             */
            var name1 = "Sourav";
            var age1 = 27;

            var message1 = string.Format("I'm {0} and {1} years old.", name1, age1);
            //Console.WriteLine(message);

            /*
             * 2) $"{}" introduces in C#6
             */
            var name2 = "Sourav";
            var age2 = 27;

            var message2 = $"I'm {name2} and {age2} years old.";
            //Console.WriteLine(message2);

            /*
             * String Literals
             * next line-> \n, tab-> \t, \r, \\
             */
            string columns = "Column 1\tColumn 2\tColumn 3";
            string rows = "Row 1\nRow 2\nRow 3";

            //Console.WriteLine(columns);
            //Console.WriteLine(rows);

            /*
             * Multi-line Strings
             * @""
             */
            var text1 = @"This is a text
                        on multiple
                        lines";
            //Console.WriteLine(text1);

            string filePath = @"C:\Users\Public\Documents";
            //Console.WriteLine(filePath);

            /*
             * String Literal and Interpolation combo
             * $@""
             */
            string literalInterpolation = $@"C:\Users\{name2}\{age2}";
            //Console.WriteLine(literalInterpolation);

            /*
             * String Equality  
             * ==
             */
            var name = "Daniel";
            var secondName = "Daniel";

            if (name == secondName)
            {
                //Console.WriteLine("Yes the strings are equal");
            }

            /*
             * string.Equals
             */
            if (string.Equals(name, secondName))
            {
                //Console.WriteLine("these strings are equal");
            }

            /*
             * Ignoring case
             */
            var first = "Daniel";
            var second = "daniel";
            if (first.Equals(second, StringComparison.OrdinalIgnoreCase))
            {
                //Console.WriteLine("Yes, they are equal");
            }

            /*
             * Compare
             * The Compare method compares the ASCII codes of each character.
             */
            var firstStr = "break";
            var secondStr = "Break";

            if (String.Compare(firstStr, secondStr) < 0)
            {
                //Console.WriteLine("first");
            }

            /*
             * STRING MANIPULATION METHODS
             * 1) Substring
             * This method returns a brand-new string, So, we can get only a part of a string.
             */
            var text = "It's a cold day in the woods";

            var subtext = text.Substring(5, 10);
            //Console.WriteLine(subtext);

            /*
             * 2) Join
             * We can create a new string based on an array of values and a separator.
             */
            var numbers = new[] { 1, 2, 3, 4, 5 };
            var results = string.Join(", ", numbers);
            //Console.WriteLine(results);

            /*
             * 3) Concat
             * We can combine two string together
             * string.Concat
             */
            text = string.Concat(text, " of the village");
            //Console.WriteLine(text);

            // +
            //+ operator can be used as concatenation operator.
            text += " ,but the cities are hot";
            //Console.WriteLine(text);

            /*
             * Replace
             * We can replace any string occurance inside of a string
             */
            text = text.Replace("cold", "warm");
            //Console.WriteLine(text);

            /*
             * ToUppper
             * We can transform all the characters of a string to upper case
             */
            text = text.ToUpper();
            //Console.WriteLine(text);

            /*
             * ToLower
             * We can transform all the characters of a string to lower case
             */
            text = text.ToLower();
            //Console.WriteLine(text);

            /*
             * Insert
             * We can insert another sequence inside of a string
             */
            text = text.Insert(12, "foggy ");
            //Console.WriteLine(text);

            /*
             * IndexOf
             * We can find the starting index of a specific string inside another one.
             */
            var index = text.IndexOf("warm");
            //Console.WriteLine(index);

            /*
             * Length
             * We can get the length / size of a string through the Length property
             */
            var length = text.Length;
            //Console.WriteLine(length);

            /*
             * Contains
             * We can use the Contains method to check if there is a string in another one
             */
            if (text.Contains("warm"))
            {
                //Console.WriteLine("String was found");
            }

            /*
             * Copy
             * We can copy the value of one string to another one
             */
            var anotherText = string.Copy(text);
            //Console.WriteLine(anotherText);

            /*
             * StartsWith
             * This method checks whether or not a string starts with another one
             */
            var text2 = "I am practicing C#";

            var result1 = text2.StartsWith("I am");
            //Console.WriteLine(result1);

            /*
             * EndsWith
             * This performs in the opposite way of StartsWith
             */
            var result2 = text2.EndsWith("C#");
            //Console.WriteLine(result2);

            /*
             * Trim
             * We can remove white-spaces from the beginning and end of a string with the Trim method
             */
            var phoneNumber = " 232 323 232  ";
            phoneNumber = phoneNumber.Trim();
            //Console.WriteLine(phoneNumber);

            var phoneNumber2 = ".232 323 232,";
            var chars = new char[] { '.', ',' };
            phoneNumber2 = phoneNumber2.Trim(chars);
            //Console.WriteLine(phoneNumber2);

            /*
             * ToArray
             * We can transform a string to an array
             */
            var textAsArray = text.ToArray();
            //Console.WriteLine(textAsArray);

            /*
             * String reversal
             * By using the Reverse and ToArray methods
             */
            var text3 = "Reversing strings is easy";

            var textReversedAsArray = (text3.Reverse().ToArray());
            //Console.WriteLine(textReversedAsArray);

            //Then we can transform it into a string
            var textReversed = new string(textReversedAsArray);
            //Console.Write(textReversed);

            /*
             * Splitting
             * We can split any string into separate parts based on a specified character
             */
            var list = "coconut,melon,avocado";
            var fruits = list.Split(',');

            foreach (var fruit in fruits)
            {
                //Console.WriteLine(fruit);
            }

            //Removing empty entries
            var list2 = "coconut,,melon,avocado,";
            var charSeparators = new char[] { ',' };
            var fruits2 = list2.Split(charSeparators, StringSplitOptions.RemoveEmptyEntries);

            foreach (var fruit in fruits2)
            {
                //Console.WriteLine(fruit);
            }

            //We can set the maximum number of substrings which will be returned
            var list3 = "coconut,,melon,avocado,";
            var charSeparators2 = new char[] { ',' };
            var fruits3 = list3.Split(charSeparators2, 2);

            foreach (var fruit in fruits3)
            {
                //Console.WriteLine(fruit);
            }
        }

    }
}
