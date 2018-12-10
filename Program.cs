using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DateTimeExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime myDate = DateTime.Now;
            string formattedDate = "";
            formattedDate = string.Format("{0:dd-MM-yyyy HH:mm:ss}",myDate);
            Console.WriteLine(formattedDate);
            
        }
    }
}
