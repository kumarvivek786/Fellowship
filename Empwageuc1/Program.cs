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
            //UC-4 
            const int FULL_TIME = 1;
            const int PART_TIME = 2;
            const int EMP_RATE_PER_HR = 20;
            int empHrs = 0,empWage = 0;
            Random random = new Random();
            int empCheck = random.Next(0, 3);
            
            Console.WriteLine("Random value:" + empCheck);

            switch(empCheck)
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
            Console.WriteLine("Employee Wage Per Day:" + empWage);

                Console.ReadLine();
        }
    }
}
