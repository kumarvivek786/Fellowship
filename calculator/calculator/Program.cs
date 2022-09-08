using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int res;
            Console.WriteLine("enter no. 1 :");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter no. 2");
            int num2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter sumbol(+,-,/,*):");
            string symbol = Console.ReadLine();

            switch(symbol)
            {
                case "+":
                    res = num1 + num2;
                    Console.WriteLine("Addition :" + res);
                    break;

                case "-":
                    res = num1 - num2;
                    Console.WriteLine("subtraction :" + res);
                    break;

                case "*":
                    res = num1 * num2;
                    Console.WriteLine("multiplication :" + res);
                    break;

                case "/":
                    res = num1 / num2;
                    Console.WriteLine("Division :" +res);
                    break;

                default:
                    Console.WriteLine("wrong input");
                    break;
            }
                    Console.ReadLine();



        }
    }
}
