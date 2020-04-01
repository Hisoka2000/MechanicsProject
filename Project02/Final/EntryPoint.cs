using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final
{
    class EntryPoint
    {
        public static void Main()
        {
            System.Console.Out.WriteLine("Hello World");


        #if DEBUG
            Console.WriteLine("Press enter to close...");
            Console.ReadLine();
        #endif
        }
    }
}
