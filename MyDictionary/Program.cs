using System;
using System.Collections.Generic;

namespace MyDictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            MyDictioanary<int, string> myDictionary= new MyDictioanary<int, string>();
            myDictionary.Add(1, "istanbul");
            myDictionary.Add(2, "Rize");
            myDictionary.Add(3, "Trabzon");
            myDictionary.Add(4, "Samsun");


            myDictionary.List();
        }
    }
}
