using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inheritance
{
    class car
    {
        public string model;
        public string color;
        public int price;

        public void printcarinfo()
        {
            Console.WriteLine("model:" + model);    
            Console.WriteLine("color:" + color);
            Console.WriteLine("price:" + price); 
        }
    }
}
