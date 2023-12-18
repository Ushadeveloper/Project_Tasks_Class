using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Tasks_Class.Shape
{
    class shapes
    {
        public void triangle1_10()
        {
            int number = 1;
            for (int i = 1; i <= 4; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write(" "+number);
                    number++;
                }
                
                Console.Write("\n");
            }
            

        }
        public void triangle123()
        {
            int number1 = 1;
            for (int i = 1; i <= 4; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write(" " + number1);
                    
                }
                number1++;

                Console.Write("\n");
            }

        }
        public void right()
        {
            for (int i = 1; i <= 4; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write(" " + j);

                }
                Console.Write("\n");

            }
        }
    }

}
