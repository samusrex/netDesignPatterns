using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeProj
{
    public class Circle : Shape
    {

        private int x, y, radius;
        public Circle(IDrawAPI api) : base(api)
        {
           
        }

        public Circle(IDrawAPI api,int x,int i, int radius) : base(api)
        {
            this.x = x;
            this.y = i;
            this.radius = radius;
        }

        public override void Draw()
        {
            dap.DrawCircle(radius,x,y);
        }
    }
}
