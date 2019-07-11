using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C7_New_Features
{
    class Tuples
    {
        public static void UseTuples()
        {
            var fullName = GetNameById(7);
            Console.WriteLine($"Name is: {fullName.name} {fullName.surname}");
            Console.ReadKey();
        }
        public static void UseDeconstruction()
        {
            (string name, string surname) = GetNameById(7);
            Console.WriteLine($"Name is: {name} {surname}");
            Console.ReadKey();
        }
        private static (string name, string surname) GetNameById(int id)
        {
            var name = ("Carlos", "Portuguez);
            return name;
        } 
        //It won't compile. A NuGet Package called System.ValueTuple is needed
    }
}
