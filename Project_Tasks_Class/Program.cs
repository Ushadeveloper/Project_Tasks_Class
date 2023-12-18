using Project_Tasks_Class._58_onward;
using Project_Tasks_Class.AggregateMarks;
using Project_Tasks_Class.AllownceSalary;
using Project_Tasks_Class.AreaPerameterRectangle;
using Project_Tasks_Class.Cashier;
using Project_Tasks_Class.checkvowel;
using Project_Tasks_Class.CircleAreaPerimeter;
using Project_Tasks_Class.DistanceCity;
using Project_Tasks_Class.Factorial;
using Project_Tasks_Class.Faren_celcius;
using Project_Tasks_Class.IllitracyPopulation;
using Project_Tasks_Class.Login;
using Project_Tasks_Class.MasrriedInsure;
using Project_Tasks_Class.Matrix;
using Project_Tasks_Class.Namee;
using Project_Tasks_Class.Prime;
using Project_Tasks_Class.Representation_day;
using Project_Tasks_Class.ReverseDigits;
using Project_Tasks_Class.Salaryover;
using Project_Tasks_Class.Shape;
using Project_Tasks_Class.SwipeNumbers;
using Project_Tasks_Class.Vowel;
using System;

using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Tasks_Class
{
    class Program

    {


       
        static void Main(string[] args)
        {
            //Waleed's Gross Salary-------------------------------------
            //var sall = new SalaryAllaowance();
            //sall.salry();
            //=======================================//3//=========================================>>>>


            //Aggrigate Marks-------------------------------------
            //MarksAgregate var = new MarksAgregate();
            //var.marksAg();

            //=========================================//5//=========================================>>>>

            //Rectangle Area Perimeter-------------------------------------
            //RectangleAreaPer rec = new RectangleAreaPer();
            //Console.Write("Enter the Length of the Rectangle : ");
            //double length = Convert.ToDouble(Console.ReadLine());
            //Console.Write("Enter the Breadth of the Rectangle : ");
            //double breadth = Convert.ToDouble(Console.ReadLine());
            //Console.WriteLine($"\nArea of Rectangle is  = " +
            //    $"{rec.RecArea(length,breadth)}\nPerimeter of Rectangle is  = {rec.RecPer(length, breadth)}");
            //================================================================================>>>>

            //ARea Perimeter of Circle-------------------------------------
            //AreaPerimeterCircle cir = new AreaPerimeterCircle();

            //Console.Write("Enter the radius of the Circle : ");
            //double radius = Convert.ToDouble(Console.ReadLine());
            //Console.WriteLine($"\nArea of Circle is  = " +
            //    $"{cir.cirArea(radius)}\nCircumference of circle is  = {cir.cirPer(radius)}");
            //================================================================================>>>>

            //Illterate Population-------------------------------------
            //PopulationIllitrate va = new PopulationIllitrate();
            //va.illitracy();
            //================================================================================>>>>

            //Cash Notes-------------------------------------
            //NoteCashier obj = new NoteCashier();
            //obj.cash();
            //================================================================================>>>>

            //Insured driver-------------------------------------
            //Insure oj = new Insure();
            //oj.married();
            //================================================================================>>>>

            //Reverse number-------------------------------------
            //DigitReverse re = new DigitReverse();
            //re.rev();
            //================================================================================>>>>

            //Tasks 58_onward-------------------------------------c
            Taskss ts = new Taskss();
            // ts.month_days();
            //================================================================================>>>>


            //Switch Calculator 58_onward-------------------------------------c

            //ts.SwitchCal();
            //int[] myArray = { 1, 2, 90, 4, 5 };
            //ts.PrintReverseArray(myArray);
            //ts.SortArrayDescending(myArray);
            //================================================================================>>>>

            //two string compares without-------------------------------------
            // ts.CompareStrings();
            //================================================================================>>>>

            //Cost of one item-------------------------------------
            //ts.Cost();
            //================================================================================>>>>

            //Profit or Loss in item-------------------------------------
            //ts.ProfitLoss();
            //================================================================================>>>>

            //Leap year-------------------------------------
            // ts.Leapyear();
            //================================================================================>>>>

            //Absolute Number-------------------------------------
            //ts.Absolute();
            //================================================================================>>>>

            //Leap Year Opertor-------------------------------------
            //ts.LeapOperator();
            //================================================================================>>>>

            //Person Health-------------------------------------
            // ts.PersonHealth();
            //================================================================================>>>>

            //Find Element in Array-------------------------------------
            // ts.FindElement();
            //================================================================================>>>>

            //Matrix Identity-------------------------------------
            matrixQuestion matrix = new matrixQuestion();
            matrix.matrixIdentity();
            // matrix.Squarematrix();
            //================================================================================>>>>

            //-------------------------------------
            //================================================================================>>>>

            //count vowel and constant
            //VowelContant var = new VowelContant();
            //var.CountVowelCon();

            //checkv varr=new checkv();
            //====================================================================================

            //Check day reprentation------------------------------
            //Represent_day dy = new Represent_day();
            //dy.days();
            //====================================================================================





            //Fahre yo Celcius----------------------------------
            //far_Cel fc = new far_Cel();
            //fc.faren_Celcius();
            //====================================================================================


            //Login-----------------------------------------
            //Signin log = new Signin();
            //log.Sign();
            //======================================================================================



            //Name Print..............................................
            // Person objPerson = new Person();
            // objPerson.Name = "Ahmad,Akram";
            //objPerson.Introduce();
            //--------------------------------------------------------------------------------------

            //Swipe Numbers with another Variale...................................
            //Console.Write("Enter the first number: ");
            //int num1 = Convert.ToInt32(Console.ReadLine());

            //Console.Write("Enter the second number: ");
            //int num2 = Convert.ToInt32(Console.ReadLine());

            //    Creating an object of the NumberSwapper class
            //   SwipeNumber swapper = new SwipeNumber(num1, num2);
            // Console.WriteLine($"Before swapping: First Number = {num1}, Second Number = {num2}");
            //swipper.Swapper();
            //    swipper.DisplayNumbers();
            //-------------------------------------------------------------------------------------


            //Swipe Numbers without Variale.................................
            //Console.Write("Enter the first number: ");
            //int num1 = Convert.ToInt32(Console.ReadLine());

            //Console.Write("Enter the second number: ");
            //int num2 = Convert.ToInt32(Console.ReadLine());
            // numberSwipe swipper = new numberSwipe(num1, num2);
            // Console.WriteLine($"Before swapping: First Number = {num1}, Second Number = {num2}");

            //swapper.SwapNumbers();
            //  swapper.DisplayNumbers();
            //---------------------------------------------------------------------------------

            // Distance Between City in Km conversion to cm,feet,inchs,m...........................
            //Console.Write("Enter a Distance Between two Cities  ");
            //float dis = float.Parse(Console.ReadLine());
            //distance dist = new distance(dis);
            //dist.DistanceCity();
            //dist.displaydist();
            //===================================================================================================

            //Factorial find-------------------------------------------------
            //Console.Write("Enter a Number to find there factorial =  ");
            //int factor = int.Parse(Console.ReadLine());
            //FactorialNumber factoriall = new FactorialNumber();
            //factoriall.Fact(factor);
            //====================================================================================


            //Employee Salary overtime------------------------------------------
            //Salary empSal = new Salary();
            //Console.Write("Enter to find Overtime salary of 10 Employees =  ");
            //int hours = int.Parse(Console.ReadLine());
            //empSal.Employee(hours);
            //======================================================================


            //Prime Number----------------------------------
            Console.Write("Enter the Number to check Prime: ");
            int n = int.Parse(Console.ReadLine());
            PrimeNumber primee = new PrimeNumber();
            primee.prime(n);
            //======================================================================


            //Print triangle 1 t0 10 12345678910---------------------

            //shapes triangle = new shapes();
            // triangle.triangle123();
            //////Print triangle 1 t0 10 1223334444--------------------------------------
            //triangle.right();
            //triangle.triangle1_10();

            //======================================================================================











            Console.ReadLine();

        }
    }
}
