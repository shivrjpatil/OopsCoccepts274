using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopsConcepts274
{
    internal class Polymorphism
    {
        public void Add(int a, int b)
        {
            int sum = a + b;
            Console.WriteLine("the sum of two nummberc is =" + sum);
        }

        public void Add(int a, int b, int c)
        {
            int sum = a + b + c;
            Console.WriteLine("the sum of three number is =" + sum);
        }
    }
    internal class Methodoverriding
    {
        public virtual void Addition(int a, int b)
        {
            int sum = a + b;
            Console.WriteLine("the adition function "+sum);
        }
    }
    class example : Methodoverriding
    {
        public override void Addition(int a, int b)
        {
            int sub = a - b;
            Console.WriteLine("the substraction fuction"+sub);
        }
    }
}
