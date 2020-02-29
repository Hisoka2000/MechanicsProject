using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ProjectMechanics
{

    class Entry
    {
        public static void Main(string[] args)
        {
            float speed;
            float positiveAcc;
            float negativeAcc;
            float distanceToIntersection;
            float width;
            float duration;

            Car car = new Car();
            Intersection intersection = new Intersection();

            Console.Write("Input the cars speed in km/h: ");
            speed = float.Parse(Console.ReadLine());
            car.Speed = speed;
            Console.Write("Input the cars constant positive acceleration in m/s^2: ");
            positiveAcc = float.Parse(Console.ReadLine());
            car.PositiveAcc = positiveAcc;
            Console.Write("Input the cars constant negative acceleration in m/s^2: ");
            negativeAcc = float.Parse(Console.ReadLine());
            car.NegativeAcc = negativeAcc;
            Console.Write("Input the cars distance to the intersection in meters: ");
            distanceToIntersection = float.Parse(Console.ReadLine());
            car.DistanceToIntersection = distanceToIntersection;

            Console.Write("Input the width of the intersection in meters: ");
            width = float.Parse(Console.ReadLine());
            intersection.Width = width;
            Console.Write("Input the duration of the yellow light in seconds: ");
            duration = float.Parse(Console.ReadLine());
            intersection.Duration = duration;

            if (car.shouldCarStop(intersection.Width, intersection.Duration))
            {
                Console.WriteLine("The car should start decelerating to stop");
            }
            else
            {
                Console.WriteLine("The car should accelerate to pass the intersection");
            }


            #if DEBUG
                Console.WriteLine("Press enter to close...");
                Console.ReadLine();
            #endif
        }
    }
}
