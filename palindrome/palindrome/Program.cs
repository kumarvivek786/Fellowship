using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace palindrome
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num;
            int result = 0;
            int reminder;

            Console.WriteLine("enter no");
            num = Convert.ToInt32(Console.ReadLine());
            int temp = num;


            while (num != 0)
            {
                reminder = num % 10;

                result = result * 10 + reminder;

                num = num / 10;
            }
            num = temp;

            if (num == result)
            {
                Console.WriteLine("palindrome");
            }
            else
            {
                Console.WriteLine("not palindrome");
            }
            
            Console.ReadLine();
        }
    }
}
