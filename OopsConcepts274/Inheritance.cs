using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopsConcepts274
{
    internal class Inheritance
    {
        public class car
        {
            public string Model;
            public string color;
            public int price;

            public void PrintCarInformation()
            {
                Console.WriteLine("model:" + Model);
                Console.WriteLine("Color:" + color);
                Console.WriteLine("Price:" + price);
            }
        }

        public class Maruthi : car
        {
            public int milage;
            public void PrintMilage()
            {
                Console.WriteLine("Milage:" + milage);
            }
        }
    }
}
