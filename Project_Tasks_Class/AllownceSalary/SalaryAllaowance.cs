using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Tasks_Class.AllownceSalary
{
    class SalaryAllaowance
    {
        public void salry()
        {
            Console.Write("Enter the Waleed's Salary : ");
            double sal = Convert.ToDouble(Console.ReadLine());
            double dearnessAllowance, houseRentAllowance, grossSalary;
            dearnessAllowance = sal * 0.4;
            houseRentAllowance =  sal * 0.2;
            grossSalary = sal + dearnessAllowance + houseRentAllowance;
            Console.Write($" Waleed's Gross Salary is : {grossSalary} {dearnessAllowance} {houseRentAllowance}");
            
        }
    }
}
