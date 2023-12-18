using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Tasks_Class.SwipeNumbers
{
    class SwipeNumber
    {

        private int number1;
        private int number2;

        public  SwipeNumber(int num1, int num2)
        {
            number1 = num1;
            number2 = num2;
        }

        public void SwapNumbers()
        {
            int temp = number1;
            number1 = number2;
            number2 = temp;
        }

        public void DisplayNumbers()
        {
            Console.WriteLine($"After swapping: Number1 = {number1}, Number2 = {number2}");
        }
    }
}
