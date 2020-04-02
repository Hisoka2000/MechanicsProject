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
            float[] m;
            m = new float[3];

            System system = new System();
            Console.Write("Please input the mass M1: ");
            m[0] = float.Parse(Console.ReadLine());
            Console.Write("Please input the mass M2: ");
            m[1] = float.Parse(Console.ReadLine());
            Console.Write("Please input the mass M3: ");
            m[2] = float.Parse(Console.ReadLine());

            system.M = m;

            float[] friction;
            friction = new float[3];

            Console.Write("Please input friction mu1: ");
            friction[0] = float.Parse(Console.ReadLine());
            Console.Write("Please input friction mu2: ");
            friction[1] = float.Parse(Console.ReadLine());
            Console.Write("Please input friction mu3: ");
            friction[2] = float.Parse(Console.ReadLine());

            system.Friction = friction;

            float force;
            Console.Write("Please input value for Force: ");
            force = float.Parse(Console.ReadLine());

            system.Force = force;

            int time;
            Console.Write("Please input value for time: ");
            time = int.Parse(Console.ReadLine());

            system.Time = time;

            system.solveSystem();



            closeMain();
        }

        private static void closeMain()
        {
            #if DEBUG
                Console.WriteLine("Press enter to close...");
                Console.ReadLine();
            #endif
        }
    }
}
