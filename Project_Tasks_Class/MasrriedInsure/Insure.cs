using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Tasks_Class.MasrriedInsure
{
    class Insure
    {
        public void married()
        {
            Console.WriteLine("Enter the driver's marital status = ");
            char maritalStatus = Convert.ToChar(Console.ReadLine());
           
            if (maritalStatus == 'm'|| maritalStatus == 'M')
            {
                Console.WriteLine("Driver is insured......");
                
            }
            

            else if(maritalStatus == 'u' || maritalStatus == 'U')
            {
                Console.WriteLine("Enter the driver's Gender = ");
                char Gender = Convert.ToChar(Console.ReadLine());
                Console.WriteLine("Enter the driver's Age = ");
                int Age = Convert.ToInt32(Console.ReadLine());
                if (Gender != 'm' || Gender != 'M')
                {
                    if (Age > 30)
                    {
                        Console.WriteLine("Driver is insured......");

                    }
                    else
                    {
                        Console.WriteLine("Driver isnot insured......");

                    }
                }
                else if (Gender != 'f' || Gender != 'F')
                {
                    if (Age > 25)
                    {
                        Console.WriteLine("Driver is insured......");

                    }
                    else
                    {
                        Console.WriteLine("Driver isnot insured......");

                    }

                }
                else
                {
                    Console.WriteLine("Driver isnot insured......");
                }

            }
            

        }
    }
}
