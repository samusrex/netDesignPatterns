﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProtoProj
{
    public class Square : Shape
    {
        public Square()
        {
            type = "Square";
        }

        public override void Draw()
        {
            Console.WriteLine("Inside Square::draw() method");
        }
    }
}
