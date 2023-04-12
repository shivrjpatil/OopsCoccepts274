using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopsConcepts274
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcoke to oops concepts");
            ClassandObject myObject = new ClassandObject();  //This is the object creation 
            Console.WriteLine(myObject.name);                //we are creating object for ClassandObject Class
            Console.WriteLine(myObject.age);                //here object name is myObject with help of object                  
            Console.ReadLine();                           //we are accessing the variables
        }
    }
}
