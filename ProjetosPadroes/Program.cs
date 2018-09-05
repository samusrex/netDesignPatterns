using AdapterProj;
using BridgeProj;
using BuilderProj;
using ProtoProj;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetosPadroes
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Builder Pattern
            Console.WriteLine("-------Builder Pattern--------");
            MealBuilder mb = new MealBuilder();

            Meal Vegan = mb.PrepareVegMeal();
            Console.WriteLine("Preparing...Vegan");
            Vegan.ShowItems();
            Console.WriteLine("Cost:{0}", Vegan.GetCost());


            MealBuilder mbu = new MealBuilder();

            Meal HardCode = mb.PrepareNonVegMeal();
            Console.WriteLine("Preparing...Hard");
            Vegan.ShowItems();
            Console.WriteLine("Cost:{0}", HardCode.GetCost());
            #endregion
            Console.WriteLine("---------------------------");


            Console.WriteLine("-------ProtoType Pattern---------");
            ShapeCache.LoadCache();

            ProtoProj.Shape clonedShape = (ProtoProj.Shape) ShapeCache.GetShape("1");
            Console.WriteLine("Shape: {0}",clonedShape.GetType());

            ProtoProj.Shape clonedShape1 = (ProtoProj.Shape)ShapeCache.GetShape("2");
            Console.WriteLine("Shape: {0}", clonedShape1.GetType());

            ProtoProj.Shape clonedShape2 = (ProtoProj.Shape)ShapeCache.GetShape("3");
            Console.WriteLine("Shape: {0}", clonedShape2.GetType());


            Console.WriteLine("-------Adapter Pattern------");

            AudioPlayer ap = new AudioPlayer();
            ap.Play("mp4", "alone.mp4");
            ap.Play("mp3", "more_than_words.mp3");
            ap.Play("vlx","beyond_horizon.vlc");

            Console.WriteLine("-----Bridge Pattern------");

            BridgeProj.Shape red = new BridgeProj.Circle(new RedCircle(),100,100,100);
            BridgeProj.Shape green = new BridgeProj.Circle(new GreenCircle(), 100, 100, 100);

            red.Draw();
            green.Draw();

            Console.WriteLine("---------------------------");



            Console.ReadKey();
        }
    }
}
