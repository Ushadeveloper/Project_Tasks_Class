using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Tasks_Class.SwipeNumbers
{
    class numberSwipe
    {
      public int number1,number2;
        public  numberSwipe(int num1,int num2)
        {
            number1=num1;
            number2=num2;
            Console.WriteLine($"Before swapping: Number1 = {number1}, Number2 = {number2}");
        }
        public void Swapper()
        {
            number1 = number1+number2 ;
            number2 = number1 - number2;
            number1 = number1 - number2;
            Console.WriteLine($"After swapping: Number1 = {number1}, Number2 = {number2}");
        }


    }
}
