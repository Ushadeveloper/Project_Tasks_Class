using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Tasks_Class.AreaPerameterRectangle
{
    class RectangleAreaPer
    {

        public double RecArea(double length, double breadth)
        {
         return length * breadth;
        }
        public double RecPer(double length, double breadth)
        {
            return (2 * length) + (2 * breadth);
        }
    }
}
