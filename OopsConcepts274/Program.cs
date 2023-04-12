using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static OopsConcepts274.Inheritance;

namespace OopsConcepts274
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcoke to oops concepts");
            Console.WriteLine("1.Class and Object \n2.Inheritance");
            int option = Convert.ToInt32(Console.ReadLine());
            switch (option)
            {
                case 1:
                 ClassandObject myObject = new ClassandObject();   
                 Console.WriteLine(myObject.name);               
                 Console.WriteLine(myObject.age);
                    break;
                    case 2:
                    Maruthi maruthi = new Maruthi();
                    maruthi.Model = "alto";
                    maruthi.color = "white";
                    maruthi.price = 200000;
                    maruthi.milage = 22;
                    maruthi.PrintCarInformation();
                    maruthi.PrintMilage();

                    break;
            }                                                            
            Console.ReadLine();                           
        }
    }
}
