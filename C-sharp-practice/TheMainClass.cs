using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_sharp_practice
{
    class TheMainClass
    {
        static void Main(string[] args)
        {
            //Strings
            Strings strings = new Strings();
            strings.TestStrings();            
            
            //Arrays
            Arrays arrays = new Arrays();
            arrays.TestArrays();            
            
            //Dictionaries
            Dictionaries dictionaries = new Dictionaries();
            dictionaries.TestDictionaries();

            //Castings
            Castings castings = new Castings();
            castings.TestCastings();

            //Lists
            Lists lists = new Lists();
            lists.TestLists();
            
            //LINQ
            LINQ linq = new LINQ();
            linq.TestLINQ();
            
            //Operators
            Operators operators = new Operators();
            operators.TestOperators();
            
            //Numbers
            Numbers numbers = new Numbers();
            numbers.TestNumbers();
            
            //JSON
            JSON json = new JSON();
            json.TestJSON();
        }
    }
}
