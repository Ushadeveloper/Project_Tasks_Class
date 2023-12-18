using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Tasks_Class.Representation_day
{
    class Represent_day
    {
        public void days()
        {
            Console.Write("Enter the day of a Week = ");
            int day = Convert.ToInt32(Console.ReadLine());
            string result;
            switch (day)
            {
                case 1:
                    result = "Monday";
                    Console.WriteLine("{0} => {1}st day of the week", result, day);
                    break;
                case 2:
                    result = "Tuesday";
                    Console.WriteLine("{0} => {1}nd day of the week", result, day);
                    break;
                case 3:
                    result = "Wednesday";
                    Console.WriteLine("{0} => {1}rd day of the week", result, day);
                    break;
                case 4:
                    result = "Thursday";
                    Console.WriteLine("{0} => {1}th day of the week", result, day);
                    break;
                case 5:
                    result = "Friday";
                    Console.WriteLine("{0} => {1}th day of the week", result, day);
                    break;
                case 6:
                    result = "Saturday";
                    Console.WriteLine("{0} => {1}th day of the week", result, day);
                    break;
                case 7:
                    result = "Sunday";
                    Console.WriteLine("{0} => {1}th day of the week", result, day);
                    break;
                default:
                    Console.WriteLine("That's not a day..");
                    break;
            }
            }
    }
}
