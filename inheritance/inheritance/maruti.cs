﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inheritance
{
    class maruti : car
    {
        public float mileage;
       public void printmileage()
        {
            Console.WriteLine("mileage:" + mileage);
        }

    }
}
