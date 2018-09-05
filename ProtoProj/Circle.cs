using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProtoProj
{
    public class Circle : Shape
    {
        public Circle()
        {
            type = "Circle";
        }

        public override void Draw()
        {
            Console.WriteLine("Inside Circle::draw() method");
        }
    }
}
