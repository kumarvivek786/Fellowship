using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            maruti mycar = new maruti();
            mycar.model = "alto";
            mycar.color = "red";
            mycar.price = 200000;
            mycar.mileage = 24;
            mycar.printcarinfo();
            mycar.printmileage();
            Console.ReadLine();
            
         
        }
    }
}
