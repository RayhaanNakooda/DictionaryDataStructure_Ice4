using System;
using System.Collections.Generic;

namespace DictionaryDataStructure
{
    class Program
    {

        DictionaryClass dict = new DictionaryClass();

        static void Main(string[] args)
        {
            DictionaryClass.dict = new Dictionary<string, object>();

            DictionaryClass.dict.Add("pie", 3.4123);
            DictionaryClass.dict.Add("Apple Tart", "340 calories");
            DictionaryClass.dict.Add("Poltry", "Fried chickens");
            DictionaryClass.dict.Add("i", 7);

            Console.WriteLine("pi = " + DictionaryClass.GetAnyValue<double>("pi"));
            Console.WriteLine("Apple Tart = " + DictionaryClass.GetAnyValue<string>("Apple Tart"));
            Console.WriteLine("Poltry = " + DictionaryClass.GetAnyValue<string>("Poltry"));
            Console.WriteLine("i = " + DictionaryClass.GetAnyValue<int>("i"));
            Console.ReadLine();
        }
    }
}
