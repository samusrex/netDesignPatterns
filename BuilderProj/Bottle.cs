﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderProj
{
    class Bottle : IPacking
    {
        public string Pack()
        {
            return "Bottle";
        }
    }
}
