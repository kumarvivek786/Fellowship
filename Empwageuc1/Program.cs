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
            //UC-3
            int FULL_TIME = 1;
            int PART_TIME = 2;
            int EMP_RATE_PER_HR = 20;
            int empHrs = 0,empWage = 0;
            Random random = new Random();
            int empCheck = random.Next(0, 3);
            
            Console.WriteLine("Random value:" + empCheck);

            if(FULL_TIME == empCheck)
            {
                empHrs = 8;

                Console.WriteLine("FullTIme Employee is Present");

            }

            else if (PART_TIME == empCheck)
            {
                empHrs = 4;

                Console.WriteLine("PartTime Employee is Present");

            }
            else
            { 

                empHrs = 0;
                Console.WriteLine("Employee is Absent");
            }
                empWage = empHrs * EMP_RATE_PER_HR; ;
            Console.WriteLine("Employee Wage Per Day:" + empWage);

                Console.ReadLine();
        }
    }
}
