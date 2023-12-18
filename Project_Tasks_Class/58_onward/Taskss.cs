using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Tasks_Class._58_onward
{
    class Taskss
    {
        public void month_days()
        {
            int month;
            Console.WriteLine("Enter month number:");
            month = Convert.ToInt32(Console.ReadLine());
            switch (month)
            {
                case 1:
                    Console.WriteLine("31 days");
                    break;
                case 2:
                    Console.WriteLine("28 days");
                    break;
                case 3:
                    Console.WriteLine("31 days");
                    break;
                case 4:
                    Console.WriteLine("30 days");
                    break;
                case 5:
                    Console.WriteLine("31 days");
                    break;
                case 6:
                    Console.WriteLine("30 days");
                    break;
                case 7:
                    Console.WriteLine("31 days");
                    break;
                case 8:
                    Console.WriteLine("31 days");
                    break;
                case 9:
                    Console.WriteLine("30 days");
                    break;
                case 10:
                    Console.WriteLine("31 days");
                    break;
                case 11:
                    Console.WriteLine("30 days");
                    break;
                case 12:
                    Console.WriteLine("31 days");
                    break;
                default:
                    Console.WriteLine("invalid entry");
                    break;
            }
        }
        public void SwitchCal()
        {
            float result = 0;
            //Getting Input of First number
            Console.WriteLine("Enter first number");
            float num1 = float.Parse(Console.ReadLine());

            //Getting Input of second number
            Console.WriteLine("Enter second number");
            float num2 = float.Parse(Console.ReadLine());

            //Getting the math operator
            Console.WriteLine("Enter operator");
            string op = Console.ReadLine();

            switch (op)
            {

                case "+":
                    result = num1 + num2;
                    break;
                case "-":
                    result = num1 - num2;
                    break;
                case "*":
                    result = num1 * num2;
                    break;
                case "/":
                    result = num1 / num2;
                    break;
                case "%":
                    result = num1 % num2;
                    break;



            }
            Console.WriteLine("Result = " + result);
        }
        public void PrintReverseArray(int[] arr)
        {
            int i = arr.Length - 1;
            while (i >= 0)
            {
                Console.WriteLine(arr[i]);
                i--;
            }

        }
        public void SortArrayDescending(int[] arr)
        {
            Array.Sort(arr);
            Array.Reverse(arr);
            foreach (int i in arr)
            {
                Console.WriteLine(i);
            }
            
        }
        public void CompareStrings()
        {
            Console.WriteLine("Write a First String : ");
            string s1 =Console.ReadLine();
            Console.WriteLine("Write a Second String : ");
            string s2 = Console.ReadLine();

            bool result = true;

            for (int i = 0; i < s1.Length; i++)
            {
                if (s1 != s2)
                {
                    result = false;
                }
                else
                {
                    result = true;
                }
            }
            if (result == true)
            {
                Console.WriteLine("Two string are compared...");
            }
            else
            {
                Console.WriteLine("Two string arenot compared...");

            }

        }
        public void Cost()
        {
            Console.Write("Enter th total selling price of 15 items : ");
            double totalSellingPrice = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter the total profit earned on the 15 items : ");
            double totalProfit = Convert.ToDouble(Console.ReadLine());
            double costPrice = totalSellingPrice - totalProfit;
            Console.Write($"the cost price of the 15 items :{costPrice} ");

            double costPricePerItem = costPrice/15;
            Console.WriteLine($"\ncost price of one item : {costPricePerItem} ");



        }
        public void ProfitLoss()
        {
            Console.Write("Enter the Selling Price of items : ");
            double totalSellingPrice = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter the total Cost Price of items : ");
            double totalCost = Convert.ToDouble(Console.ReadLine());
            double PLPrice = totalSellingPrice - totalCost;
            Console.Write($"the cost price  :{PLPrice} ");
            if (PLPrice > 0)
            {
                Console.WriteLine($"\nYou have earn extra Money and your profit is : {PLPrice} ");
            }
            else if (PLPrice < 0)
            {
                Console.WriteLine($"\nYou have debut {PLPrice*-1} Money and your get incurred loss : {PLPrice*-1} ");
            }
            else 
            {
                Console.WriteLine($"\nNo profit or loss ");
            }
          
        }
        public void Leapyear()
        {
            Console.Write("Enter the year to Know Leap Year or not : ");
            int year = int.Parse(Console.ReadLine());
            if (year % 4 != 0)
            {
                if (year % 100 != 0)
                {
                    if(year % 400 != 0)
                    {
                        Console.WriteLine("This Year isnot Leap Year... ");
                    }
                }
            }
            else
            {
                Console.WriteLine("This Year is Leap Year... ");

            }
        }
        public void Absolute()
        {
            Console.Write("Enter the Number to Find Aboulute or nOt : ");
            int num = int.Parse(Console.ReadLine());
            if (num >= 0)
            {
                Console.WriteLine($"You Enter a Positive number {num}....... ");

                Console.WriteLine("\nThis number is Already Abosulte....... ");
            }
            else
            {
                Console.WriteLine($"You Enter a Negitive number {num}....... ");

                num = num * -1;
                Console.WriteLine($"\nNow this number is Abosulte Its value is {num}....... ");


            }
        }

        public void LeapOperator()
        {
            Console.Write("Enter the year to Know Leap Year or not : ");
            int year = int.Parse(Console.ReadLine());
            if ((year % 4 != 0) && (year % 100 != 0) && (year % 400 != 0))
            {
                Console.WriteLine("This Year isnot Leap Year... ");

            }
            else
            {
                Console.WriteLine("This Year is Leap Year... ");

            }

        }
        public void PersonHealth()
        {
            Console.Write("Enter the health status of Person : ");
            string health = Console.ReadLine();
            health=health.ToLower();
            Console.Write("Enter the age of Person : ");
            int age = int.Parse(Console.ReadLine());
            Console.Write("Enter the gender of Person : ");
            string gender = Console.ReadLine();
            gender = gender.ToLower();
            Console.Write("Enter the location status of Person : ");
            string location = Console.ReadLine();
            location = location.ToLower();
            if ((health == "excilent")&&(age>25&&age<30)&&(gender=="male")&&(location=="city"))
            {
                Console.WriteLine("The premium is Rs. 40 per thousand and the policy amount cannot exceed Rs. 2 Lakh");
            }
           else if ((health == "excilent") && (age > 25 && age < 30) && (gender == "female") && (location == "city"))
            {
                Console.WriteLine("The premium is Rs. 30 per thousand and the policy amount cannot exceed Rs. 1 Lakh");
            }
            else if ((health == "poor") && (age > 25 && age < 30) && (gender == "male") && (location == "village"))
            {
                Console.WriteLine("The premium is Rs. 60 per thousand and the policy amount cannot exceed Rs. 10,000");
            }
            else
            {
                Console.WriteLine("The person is not insured");
            }

        }
        public void FindElement()
        {
            int[] element = new int[] { 1, 2, 3, 4,5 };
            Console.WriteLine("Enter the nuber : ");
            int num = Convert.ToInt32(Console.ReadLine());
            bool result = true; int i = 1;
            for (; i < element.Length; i++)
            {
                if (num == element[i])
                {
                    result = true;
                    if (result == true)
                    {
                        break;
                    }
                    
                }
                else
                {
                    result = false;
                    continue;


                }


            }
            if (result == true) {
                Console.WriteLine($"Element is in {i} index and  the Element is {element[i]}");


            }
            else
            {
                Console.WriteLine($"Element isnot in Element Array");

            }

        }




    }
}
