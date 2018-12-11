using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodsPart1
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b, c, d;
            int addResult = 0;
            a = 5;
            b = 3;
            addResult = PerformAddOperation(a, b);
             Console.WriteLine($"{a} +{b} = {addResult}");
             DisplayMessage();
            //  PerformAddOperation(a, b);

            c = 15;
            d = 10;
            addResult = PerformAddOperation(c, d);
            Console.WriteLine($"{c} +{d} = {addResult}");
            DisplayMessage();
            //PerformAddOperation(c, d);

        }
        static int PerformAddOperation(int x, int y)
        {
            int addResult = 0;
            addResult = x + y;
            //Console.WriteLine($"{x} +{y} = {addResult}");
            //DisplayMessage();
            return addResult;

        }

        static void DisplayMessage()
        {
            Console.WriteLine("Process is done");
            Console.WriteLine("This process is run by Roheel");
            Console.WriteLine("Finished on time : "+DateTime.Now.ToShortTimeString());
        }
    }
}
