using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderProj
{
    public class VegBurger : Burger
    {
        public override string Name()
        {
            return typeof(VegBurger).Name;
            
        }

        public override float Price()
        {
            return 0.25f;
        }
    }
}
