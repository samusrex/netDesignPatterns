﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderProj
{
    public abstract class ColdDrink : ITem
    {
        public abstract string Name();
        

        public IPacking Packing()
        {
            return new Bottle();
        }

        public abstract float Price();

    }
}