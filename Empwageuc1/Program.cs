using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Empwageuc1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CalculateEmpWage("Delloite",20,70,40);
            CalculateEmpWage("Microsoft",18, 60,90);
            CalculateEmpWage("Infosys",15,55,100);
            Console.ReadLine();
        }
        
        public static void CalculateEmpWage(string company,int maxWorkingDays, int maxWorkingHrs, int empRatePerHr)
        {
            //UC-7 
            const int FULL_TIME = 1;
            const int PART_TIME = 2;
            int empHrs = 0, empWage = 0, totalEmpwage = 0, day = 1, totalHrs = 0;
            Random random = new Random();

            while (day<= maxWorkingDays && totalHrs<= maxWorkingHrs)
            {

                int empCheck = random.Next(0, 3);

                //Console.WriteLine("Random value:" + empCheck);

                switch (empCheck)
                {
                    case FULL_TIME:
                        empHrs = 8;
                        // Console.WriteLine("FullTime Employee is Present");
                        break;
                    case PART_TIME:
                        empHrs = 4;
                        //Console.WriteLine("PartTime Employee is Present");
                        break;
                    default:
                        break;

                }

                empWage = empHrs * empRatePerHr; ;
                totalHrs += empHrs;
               // Console.WriteLine("Employee Wage on Day{0} and Hrs {1} is {2}", day, totalHrs, empWage);
                //totalEmpwage = totalEmpwage + empWage;
                totalEmpwage += empWage;
                day++;
                

            }
            Console.WriteLine("\nTotal Empwage of {0} is {1}",company,totalEmpwage);
        }
    }
}
