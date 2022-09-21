using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Empwageuc1
{
        public class Program
    {
        public string company;
        public int maxWorkingDays, maxWorkingHrs, empRatePerHr;

        public Program(string comp, int maxWorkingDays, int maxWorkingHrs, int empRatePerHr)        {
            company = comp;
            this.maxWorkingDays = maxWorkingDays;
            this.maxWorkingHrs = maxWorkingHrs;
            this.empRatePerHr = empRatePerHr;
           

        }
            public void CalculateEmpWage()
        {
            //UC-9 
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

                empWage = empHrs * empRatePerHr;
                totalHrs += empHrs;
               // Console.WriteLine("Employee Wage on Day{0} and Hrs {1} is {2}", day, totalHrs, empWage);
                //totalEmpwage = totalEmpwage + empWage;
                totalEmpwage += empWage; 
                day++;


            }
            Console.WriteLine("\nTotal Empwage of {0} is {1}",company,totalEmpwage);
        }
        static void Main(string[] args)
        {
            Program Delloite = new Program("Delloite", 20, 70, 40);
            Delloite.CalculateEmpWage();
            Program Microsoft = new Program("Microsoft", 18, 60, 90);
            Microsoft.CalculateEmpWage();
            Program Infosys = new Program("Infosys", 15, 55, 100);
            Infosys.CalculateEmpWage();
            Console.ReadLine();


        }
    }
}
