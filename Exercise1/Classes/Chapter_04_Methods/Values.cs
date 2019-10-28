﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Exercise1.Classes.Chapter_04_Methods
{
    public class Values
    {
        public double Value1 { get; }
        public double Value2 { get; }
        public double Result { get; set; }
        public Operators Operator { get; set; }

        public Values()
        {
        }

        public Values(double value1, double value2)
        {
            Value1 = value1;
            Value2 = value2;
        }
    }
}
