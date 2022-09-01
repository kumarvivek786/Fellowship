using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace reverseno
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int num = 1234;
            int result = 0;
            int reminder;

            while (num != 0)
            {
                reminder = num % 10;

                result = result*10 + reminder;

                num = num / 10;
            }
            Console.WriteLine(result);
            Console.ReadLine();
        }
    }
}
