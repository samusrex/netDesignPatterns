using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeProj
{
    public abstract class Shape
    {
        protected IDrawAPI dap;

        protected Shape(IDrawAPI api)
        {
            this.dap = api;
        }

        public abstract void Draw();
    }
}
