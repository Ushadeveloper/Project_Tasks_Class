using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Tasks_Class.AggregateMarks
{
    class MarksAgregate
    {
        public void marksAg()
        {
            double aggre = 0;double percentage=0;

            for (int  i = 1; i <= 5; i++)
            {
                repeat:
                Console.Write("Enter the marks of Subject {0} = ",i);
                
                double marks = Convert.ToDouble(Console.ReadLine());
                
                if (marks <= 100)
                { 
                    aggre = marks + aggre; 
                }
                else
                {
                    Console.Write("\nEnter the marks under 100 \n");

                    goto repeat;
                }

            }
            
            percentage=aggre*100/500;
            Console.WriteLine("\nPercentage of the Student is : {0} % ", percentage);
             
        }
        
    }
}
