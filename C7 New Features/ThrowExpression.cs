using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C7_New_Features
{
    class ThrowExpression
    {
        public static void DoDivision()
        {
            double result = Divide(10, 6);
            Console.WriteLine($"The result is: {result}");
            Console.ReadKey();
            
        }
        int x;
        private void method()
        {
            
            Console.WriteLine(x);
        }

        private static double Divide(int num1, int num2)
        {
            return num2 != 0 ? num1 / num2 : throw new DivideByZeroException();
        }
    }
}
