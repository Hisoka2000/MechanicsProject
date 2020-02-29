using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectMechanics
{
    class Intersection
    {
        private float width = 0;
        private float duration = 0;

        public float Width
        {
            get
            {
                return width;
            }

            set
            {
                width = value;
                while (width < 5 || width > 20)
                {
                    Console.WriteLine("Width has to be between 5 and 20 included");
                    Console.Write("Please enter a new value: ");
                    width = float.Parse(Console.ReadLine());
                }
            }
        }

        public float Duration
        {
            get
            {
                return duration;
            }

            set
            {
                duration = value;
                while (duration < 2 || duration > 5)
                {
                    Console.WriteLine("Duration has to be between 20 and 80 included");
                    Console.Write("Please enter a new value: ");
                    duration = float.Parse(Console.ReadLine());
                }
            }
        }
    }
}
