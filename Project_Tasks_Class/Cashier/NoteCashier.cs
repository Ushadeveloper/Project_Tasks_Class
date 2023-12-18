using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Tasks_Class.Cashier
{
    class NoteCashier
    {
        public void cash()
        {
            Console.WriteLine("Enter the Amount in Digits = ");
            int amount = Convert.ToInt32(Console.ReadLine());
            int hundreds = amount / 100;
            int Fifties = (amount % 100) / 50;
            int tens=(((amount % 100) % 50) / 10);
            Console.WriteLine($"No of Hundreds = {hundreds}\nNo of fifties = {Fifties}" +
                $"\nNo of tens = {tens}");

        }
    }
}
