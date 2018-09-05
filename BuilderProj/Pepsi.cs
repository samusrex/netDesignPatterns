using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderProj
{
    class Pepsi : ColdDrink
    {
        public override string Name()
        {
            return typeof(Pepsi).Name;
        }

        public override float Price()
        {
            return 3.56f;
        }
    }
}
