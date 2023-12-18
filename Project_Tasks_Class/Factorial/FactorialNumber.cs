using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Tasks_Class.Factorial
{
    class FactorialNumber
    {
        public void Fact(int num)
        {
            int fac = 1, k = 1;
            for (; k <= num; k++)
            {
                fac = k * fac;
                
            }
            Console.WriteLine($"\nFactorial of {num} is {fac}");
        }
           
            
    }
}
