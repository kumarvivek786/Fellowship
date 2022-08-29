using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fellowship
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome To Fellowship");
         
            //maruti object
            Car maruti = new Car();
            maruti.color = "red";
            maruti.price = "70000";
            maruti.model = "baleno";
            maruti.display();
            //bmw objext
            bmw.color = "white";
            bmw.price = "90000"
            bmw.model = "x5";
            bmw.display();
            Console.ReadLine();
                }
    }
}
