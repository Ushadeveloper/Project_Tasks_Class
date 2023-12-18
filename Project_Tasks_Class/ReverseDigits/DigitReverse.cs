using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Tasks_Class.ReverseDigits
{
    class DigitReverse
    {
        public void rev()
        {
            Console.WriteLine("Enter a 5 Digit Number = ");
            int digit = Convert.ToInt32(Console.ReadLine());
            int reverse = 0, rem = 0;
            while (digit != 0)
            {
                rem = digit % 10;
                reverse = reverse * 10 + rem;
                digit /= 10;
            }
            Console.Write("Reversed Number: " + reverse);

        }

    }
}
