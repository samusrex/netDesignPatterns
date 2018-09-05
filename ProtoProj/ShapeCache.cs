using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProtoProj
{
    public class ShapeCache
    {

        private static Dictionary<string, Shape> ShapeMap = new Dictionary<string, Shape>();

        public static Shape GetShape(String shapeId)
        {
            if (ShapeMap.TryGetValue(shapeId, out Shape value))
            {
                return (Shape)value.Clone();
            }
            return null;
        }
        public static void LoadCache() {

            Circle circle = new Circle();
            circle.SetId("1");
            ShapeMap.Add(circle.GetId(),circle);

            Square square = new Square();
            square.SetId("2");
            ShapeMap.Add(square.GetId(), square);

            Rectangle rect = new Rectangle();
            rect.SetId("3");
            ShapeMap.Add(rect.GetId(), rect);



        }
    }
}
