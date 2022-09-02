using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sumofdigit
{
    internal class Program
    {
        static void Main(string[] args)
        {

        

            {
                int number;
                int sum = 0, digit = 0;

                Console.WriteLine("enter no.");
                number = Convert.ToInt32(Console.ReadLine());

                while (number!=0)


                { digit = number % 10;
                    sum = sum + digit;
                    number = number / 10;
                }Console.WriteLine("sum of no:"+sum );
                Console.ReadLine();
            }
        }

    }
}
