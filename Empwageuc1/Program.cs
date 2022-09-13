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
            //UC-2
            int EMP_PRESENT = 1;
            int EMP_RATE_PER_HR = 20;
            int empHrs = 0,empWage = 0;
            Random random = new Random();
            int empCheck = random.Next(0, 2);
            
            Console.WriteLine("Random value:" + empCheck);

            if(EMP_PRESENT == empCheck)
            {
                empHrs = 8;

                Console.WriteLine("Employee is Present");

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
