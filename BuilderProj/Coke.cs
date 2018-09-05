using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderProj
{
    class Coke : ColdDrink
    {
        public override string Name()
        {
            return "Coke";
        }

        public override float Price()
        {
            return 1.2f;
               
        }
    }
}
