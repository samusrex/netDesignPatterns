using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderProj
{
    public class Meal
    {
        private List<ITem> items = new List<ITem>();

        public void AddItem(ITem item)
        {

            items.Add(item);
        }

        public float GetCost()
        {

            float cost = 0.0f;

            foreach (var i in items)
            {
                cost += i.Price();
            }

            return cost;
        }

        public void ShowItems()
        {

            foreach (var i in items)
            {

                Console.WriteLine("Item:{0}", i.Name());
                Console.WriteLine("Packing:{0}", i.Packing().Pack());
                Console.WriteLine("Price:{0}", i.Price());


            }
        }

    }
}
