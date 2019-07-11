using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C7_New_Features
{
    class BinaryDecimal
    {
        public static void RepresentNumber()
        {
            //Represent 50 in decimal, hexadecimal & binary  
            int a = 50; // decimal representation of 50  
            int b = 0X32; // hexadecimal representation of 50  
            int c = 0B110010; //binary representation of 50
            //Console.WriteLine($ "a: {a:0000} b: {b:0000} c: {c:0000}");
            Console.WriteLine($"a: {a}   b: {b}   c: {c}");
            Console.ReadKey();
        }
    }
}
