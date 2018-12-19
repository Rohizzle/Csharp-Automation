using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstraction
{
    class Program
    {
        static void Main(string[] args)
        {
            Lines Line = new Lines();
            Line.sayHi(); Line.Draw();
        }
    }
    abstract class Shapes
    {
        abstract public void Draw();
        public void sayHi()
        {
            Console.WriteLine("Hi from the abstract class");
        }

    }
    class Lines:Shapes
    {
    public override void Draw()
        {
            Console.WriteLine("Hi I am a line");
        }
    }
}

