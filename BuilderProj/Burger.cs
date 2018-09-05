using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderProj
{
    public abstract class Burger : ITem
    {
        public abstract string Name();
        

        public virtual IPacking Packing()
        {
            return new Wrapper();
        }

        public abstract float Price();
        
            
        
    }
}
