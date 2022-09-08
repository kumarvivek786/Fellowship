using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace evenodd
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num;
            
            Console.WriteLine("enter no. :");
            num = Convert.ToInt32(Console.ReadLine());
            if (num%2==0)
            {
                Console.WriteLine("Prime Number");
            }
            
            else
            {
                Console.WriteLine("Odd Number");

            }
            Console.ReadLine();
        }
    }
}
