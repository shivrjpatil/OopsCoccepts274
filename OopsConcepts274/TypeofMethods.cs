using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopsConcepts274
{
    internal class TypeofMethods
    {
        public void Nonstaticmethod()                      //NON STATIC METHOD
        {
            int a=5, b=5, c;
            c = a + b;
            Console.WriteLine("the addition="+c);
        }

        static public void Staticmethod()               //STATIC METHOD
        {
            int a=5,b=5,c;
            c = a * b;
            Console.WriteLine("the multipkication="+c);
        }
    }
}
