using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C7_New_Features
{
    class NestedFunctions //Class to test nested functions
    {
        public static void DoMultiplication()
        {
            int firstNum, result;
            bool finishedSuccessfully = false;
            while (!finishedSuccessfully)
            {
                Console.WriteLine("Type the first number to multiply:  ");
                if (int.TryParse(Console.ReadLine(), out firstNum))
                {
                    //First number's format is correct
                    Console.WriteLine("Type the second number to multiply:  ");
                    if (int.TryParse(Console.ReadLine(), out result))
                    {
                        //Second number's format is also correct
                        Multiply();
                        Console.WriteLine($"The result of the multiplication is {result}");
                        finishedSuccessfully = true;
                        Console.ReadKey();
                    }
                    else
                    {
                        //Second number's format is wrong
                        Console.WriteLine("The typed input must be an integer...");
                        Console.WriteLine();
                        Console.ReadKey();
                    }
                }
                else
                {
                    //First number's format is wrong
                    Console.WriteLine("The typed input must be an integer...");
                    Console.WriteLine();
                    Console.ReadKey();
                }
            }

            void Multiply() //Nested function inside Main
            {
                SaySomething();  //<-- It can call another nested function!
                result *= firstNum;
            }

            void SaySomething()
            {
                Console.WriteLine("Hello World!");
            }
        }
    }
}
