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
            //UC-5 
            const int FULL_TIME = 1;
            const int PART_TIME = 2;
            const int EMP_RATE_PER_HR = 20;
            const int MAX_WORKING_DAYS = 20;
            int empHrs = 0,empWage = 0,totalEmpwage= 0;
            Random random = new Random();

            for (int day=1;day<=MAX_WORKING_DAYS;day++)
            {

                int empCheck = random.Next(0, 3);

                Console.WriteLine("Random value:" + empCheck);

                switch (empCheck)
                {
                    case FULL_TIME:
                        empHrs = 8;
                        Console.WriteLine("FullTime Employee is Present");
                        break;
                    case PART_TIME:
                        empHrs = 4;
                        Console.WriteLine("PartTime Employee is Present");
                        break;
                    default:
                        break;

                }

                empWage = empHrs * EMP_RATE_PER_HR; ;
                Console.WriteLine("Employee Wage on Day{0} is {1}",day,empWage);
                //totalEmpwage = totalEmpwage + empWage;
                totalEmpwage+=empWage;

            }
            Console.WriteLine("\nTotal Empwage is;" + totalEmpwage);
                Console.ReadLine();
        }
    }
}
