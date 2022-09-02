using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace reverseofword
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string word="";

            Console.WriteLine("enter word:");
            word =Console.ReadLine();

            string reverse = "";

            int n = 0;

            char[] charArr=word.ToCharArray();
            n = charArr.Length;

            for (int i = n-1; i >= 0; i--)

            { reverse = reverse + charArr[i]; 
            
            }
            Console.WriteLine("after reverse :"+reverse);
            Console.ReadLine(); 


        }
    }
}
