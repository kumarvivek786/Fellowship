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
            //UC-6 
            const int FULL_TIME = 1;
            const int PART_TIME = 2;
            const int EMP_RATE_PER_HR = 20;
            const int MAX_WORKING_DAYS = 20;
            const int MAX_WORKING_HRS = 100;
            int empHrs = 0, empWage = 0, totalEmpwage = 0, day = 1,totalHrs=0; 
            Random random = new Random();

            while(day<MAX_WORKING_DAYS && totalHrs<=MAX_WORKING_HRS)
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

                empWage = empHrs * EMP_RATE_PER_HR; ;
                totalHrs+=empHrs;
                Console.WriteLine("Employee Wage on Day{0} and Hrs{1} is {2}",day,empHrs,empWage);
                //totalEmpwage = totalEmpwage + empWage;
                totalEmpwage+=empWage;
                day++;
                totalHrs+= empHrs;
                 
            }
            Console.WriteLine("\nTotal Empwage is;" + totalEmpwage);
                Console.ReadLine();
        }
    }
}
