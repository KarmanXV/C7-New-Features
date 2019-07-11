using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C7_New_Features
{
    class DigitSeparator
    {
        public static void ShowNumber(int number)
        {
            Console.WriteLine($"The number received is: {number}");
            int decimalNum = 1_23_456_78___________9;
            int hexadecimalNum = 0X1_FB__4;
            int binaryNum = 0B101010__________________10101010;
            Console.WriteLine($"Some more numbers are: {decimalNum}, {hexadecimalNum}, {binaryNum}");
            Console.ReadKey();
        }
    }
}
