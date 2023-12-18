using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Tasks_Class.IllitracyPopulation
{
    class PopulationIllitrate
    {
        public void illitracy()
        {
            const int totalPopulation=80000;
            const double percentMen = 0.52;
            const double percentTotalLiteracy = 0.48;
            const double percentLiterateMen = 0.35;
            double totalLiterateMen = percentLiterateMen * totalPopulation;
            Console.WriteLine($"the totalLiterateMen = {totalLiterateMen} ");
            
            double totalMen = percentMen * totalPopulation;
           // Console.WriteLine($"the totalMen = {totalMen} ");

            int illiterateMen = (int)(totalMen - totalLiterateMen);
            Console.WriteLine($"the illiterateMen = {illiterateMen} ");


            int totalLiteratePopulation = (int)(percentTotalLiteracy * totalPopulation);

           // Console.WriteLine($"the totalLiteratePopulation = {totalLiteratePopulation} ");

            int totalIlliteratePopulation = (int)(totalPopulation - totalLiteratePopulation);
            //Console.WriteLine($"the totalIlliteratePopulation = {totalIlliteratePopulation} ");

            int illiterateWomen = (int)(totalIlliteratePopulation - illiterateMen);
            Console.WriteLine($"the illiterateWomen = {illiterateWomen} ");


        }
    }
}
