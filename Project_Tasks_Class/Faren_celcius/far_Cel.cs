using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Tasks_Class.Faren_celcius
{
    class far_Cel
    {
        public void faren_Celcius()
        {
            double Fahrenheit = 97;
            Console.WriteLine("Temperature in Fahrenheit is:" + Fahrenheit);
            double Celsius = (Fahrenheit - 32) * 5 / 9;
            Console.WriteLine("Temperature in celsius is:" + Celsius);
            Console.ReadLine();
        }
    }
}
