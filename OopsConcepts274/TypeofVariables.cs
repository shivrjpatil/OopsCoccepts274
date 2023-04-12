using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopsConcepts274
{
    public class TypeofVariables
    {
        //Instance Variable
         
       public int engMarks;                //engMarks and mathsMarks are instance variables
       public int mathsMarks;


        //STATIC VARIABLE
       
       public static double salary=20000.77;         //salary and name are static variables.
       public static String name = "Aks";

        //CONSTANT VARIABLE
       public const int Age = 50;
        //LOCAL VARIABLE
        
        public void Add()
        {
            int a = 10;            //a,b,c are local variables
            int b = 20;
            int c = a + b;
            Console.WriteLine("Accessing of local variable = "+c);
        }
    }
        
}
