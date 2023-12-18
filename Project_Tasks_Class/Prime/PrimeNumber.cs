using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Tasks_Class.Prime
{
    class PrimeNumber
    {
        public void prime(int num)

        {
            int a = 0;
            for (int i = 1; i <= num; i++)
            {
                if (num % i == 0)
                {
                    a++;
                }
            }
            if (a == 2)
            {
                Console.WriteLine("{0} is a Prime Number", num);
            }
            else
            {
                Console.WriteLine("Not a Prime Number");
            }
        }
    }
}
