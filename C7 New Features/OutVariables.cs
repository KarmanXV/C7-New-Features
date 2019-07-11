using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C7_New_Features
{
    class OutVariables
    {
        public static void UseNewOut()
        {
            //int number    //<-- No need to declare it beforehand!
            Console.WriteLine("Type a number:");
            if(int.TryParse(Console.ReadLine(), out int number))
            {
                Console.WriteLine($"The number is: {number}");
            }
            else
            {
                //Console.WriteLine("You must type a number");
                Console.WriteLine($"The number is: {number}"); //Exception case
            }
            Console.ReadKey();
        }
    }
}
