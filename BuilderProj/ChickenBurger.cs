using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderProj
{
    class ChickenBurger : Burger
    {
        public override string Name()
        {
            return typeof(ChickenBurger).Name;
        }

        public override float Price()
        {
            return 2.5f;
        }
    }
}
