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

            int empPresent = 1;
            Random random = new Random();
            int empCheck = random.Next(0, 2);
            
            Console.WriteLine("Random value:" + empCheck);

            if(empPresent == empCheck)
                Console.WriteLine("Employee is Present");
            else
                Console.WriteLine("Employee is Absent");
                Console.ReadLine();
        }
    }
}
