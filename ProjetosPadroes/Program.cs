using AdapterProj;
using BridgeProj;
using BuilderProj;
using FilterProj;
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

            ProtoProj.Shape clonedShape = (ProtoProj.Shape)ShapeCache.GetShape("1");
            Console.WriteLine("Shape: {0}", clonedShape.GetType());

            ProtoProj.Shape clonedShape1 = (ProtoProj.Shape)ShapeCache.GetShape("2");
            Console.WriteLine("Shape: {0}", clonedShape1.GetType());

            ProtoProj.Shape clonedShape2 = (ProtoProj.Shape)ShapeCache.GetShape("3");
            Console.WriteLine("Shape: {0}", clonedShape2.GetType());

            Console.WriteLine("---------------------------");


            Console.WriteLine("-------Adapter Pattern------");


            AudioPlayer ap = new AudioPlayer();
            ap.Play("mp4", "alone.mp4");
            ap.Play("mp3", "more_than_words.mp3");
            ap.Play("vlx", "beyond_horizon.vlc");

            Console.WriteLine("-----Bridge Pattern------");

            BridgeProj.Shape red = new BridgeProj.Circle(new RedCircle(), 100, 100, 100);
            BridgeProj.Shape green = new BridgeProj.Circle(new GreenCircle(), 100, 100, 100);

            red.Draw();
            green.Draw();

            Console.WriteLine("---------------------------");

            Console.WriteLine("-----Filter Pattern--------");

            List<Person> persons = new List<Person>();

            persons.Add(new Person("John", "MALE", "SINGLE"));
            persons.Add(new Person("Joahana", "FEMALE", "SINGLE"));
            persons.Add(new Person("John L.", "MALE", "SINGLE"));
            persons.Add(new Person("John T", "MALE", "MARRIED"));
            persons.Add(new Person("Johnny Cage", "MALE", "MARRIED"));
            persons.Add(new Person("John Travolta", "MALE", "SINGLE"));
            persons.Add(new Person("J Lo", "FEMALE", "MERRIED"));

            ICriteria male = new CriteriaMale();
            ICriteria female = new CriteriaFemale();
            ICriteria single = new CriteriaSingle();
            ICriteria singleMale = new AndCriteria(single, male);
            ICriteria singleOrFemale = new OrCriteria(single, female);

            Console.WriteLine("males:");
            PrintPersons(male.MeetCriteria(persons));

            Console.WriteLine("females:");
            PrintPersons(female.MeetCriteria(persons));

            Console.WriteLine("single:");
            PrintPersons(single.MeetCriteria(persons));

            Console.WriteLine("Singles and Males:");
            PrintPersons(singleMale.MeetCriteria(persons));

            Console.WriteLine("Female or Single:");
            PrintPersons(singleOrFemale.MeetCriteria(persons));



            Console.WriteLine("---------------------------");


            Console.ReadKey();
        }


        public static void PrintPersons(List<Person> p)
        {

            foreach (var person in p)
            {

                Console.WriteLine("Name:{0}, Gender:{1}, Status:{2}", person.GetName(), person.GetGender(), person.GetMaritalStatus());

            }

        }
    }
}
