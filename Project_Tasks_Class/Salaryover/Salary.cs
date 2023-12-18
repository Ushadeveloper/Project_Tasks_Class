using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Tasks_Class.Salaryover
{
    class Salary
    {
        public void Employee(int hours)
        {
            
            int emp = 1;int overtime = 0;
            while (emp <= 10)
            {
                
                if (hours>40)
                {

                    hours = hours - 40;
                    overtime = hours * 200 + overtime;
                    hours = hours + 40;
                }
                else
                {
                    overtime=0 ;
                    //Console.WriteLine($"You didn't work 40 hours extra So your didn,t get overtime salary ");
                  

                }
                emp++;

            }
            Console.WriteLine($"You had been worked 40 hours + extra worked " +
                $"So your overtime salary is {overtime} Rupees ");

        }
    }
}
