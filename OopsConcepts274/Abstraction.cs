using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopsConcepts274
{
    abstract class OopsDemo
    {
        abstract public void Color();
        public void Flower()
        {
            Console.WriteLine("the flower is rose");
        }
    }

    class Rose : OopsDemo
    {
        public override void Color()
        {
            Console.WriteLine("Color is red");

        }
    }
}
