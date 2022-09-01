using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fellowship
{
    internal class Program
    {
        static object Main(string[] args)
        {
            Console.WriteLine("Welcome To Fellowship");
         
            //maruti object
            Car maruti = new Car();
            maruti.color = "red";
            maruti.price = "70000";
            maruti.model = "baleno";
            maruti.Display;
            
            //bmw object
            Car bmw = new Car();
            bmw.color = "white";
            bmw.price = "90000";
            bmw.model = "x";
            bmw.Display();
            
            Console.ReadLine();
                }
    }
}
