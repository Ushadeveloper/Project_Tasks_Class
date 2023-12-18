using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Tasks_Class.Login
{
    class Signin
    {
        public void Sign()
        {
            String username = "Usama Shabir";
           String Password = "usama123";

            Console.Write("\n Enter your Username = ");
            String user = Console.ReadLine();
            Console.Write("\n Enter your Password = ");
            String pass = Console.ReadLine();

            if (username==user && Password== pass)
            {
                Console.WriteLine("\n login was successful");
            }
            else
            {
                Console.WriteLine("\n login was unsuccessful");

            }
        }
    }
}
