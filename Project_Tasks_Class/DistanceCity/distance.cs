using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Tasks_Class.DistanceCity
{
    class distance
    {
        public float dis;

        public distance(float dis)
        {
            this.dis = dis;
        }

        public void DistanceCity( )
        {
            float feet; float inches; float cent; float meter;


            meter = dis * 1000.2f; 
            feet = dis * 3280.84f; //since 1km=3280.84feet
            inches = dis * 39370.1f; //since 1 km=39370.1inches
            cent = dis * 100000.1f; //since 1km = 100000cm

            Console.WriteLine($" Distance in kilometres = {dis} Distance in feet = {feet}" +
               $" Distance in inches = {inches} " +
               $"Distance in meter = {meter} Distance in Centimeter = {cent}");

        }
        public void displaydist()
        {
           
        }
    }
}
