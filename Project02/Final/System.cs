using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final
{
    class System
    {
        readonly int G = 10;

        private float[] m = new float[3];
        private float[] friction = new float[3];
        private float[,] position;
        private float force;
        private int time;

        public System()
        {
            position = new float[,] { { 5, 7}, { 3, 7}, { 5, 6} };
        }

        public float[] M
        {
            get
            {
                return m;
            }
            set
            {
                m = value;
                for(int i = 0; i < m.Length; i++)
                {
                    while(m[i] <= 0 || m[i] > 10)
                    {
                        Console.WriteLine("Masses need to be greater than 0 or less than or equal to 10");
                        Console.Write("Please enter a new value for M" + i + ": ");
                        m[i] = (int)Console.Read();
                    }
                }
            }
        }

        public float[] Friction
        {
            get
            {
                return friction;
            }
            set
            {
                friction = value;
                for (int i = 0; i < friction.Length; i++)
                {
                    while (friction[i] < 0 || friction[i] > 0.5)
                    {
                        Console.WriteLine("Frictions need to be greater than or equal to 0 or less than or equal to 0.5");
                        Console.Write("Please enter a new value for friction" + i + ": ");
                        friction[i] = (int)Console.Read();
                    }
                }
            }
        }

        public float Force
        {
            get
            {
                return force;
            }
            set
            {
                force = value;
                while (force < -300 || force > 300)
                {
                    Console.WriteLine("Force needs to be greater than or equal to -300 or less than or equal to 300");
                    Console.Write("Please enter a new value for Force: ");
                    force = (int)Console.Read();
                }
            }
        }

        public int Time
        {
            get
            {
                return time;
            }
            set
            {
                time = value;
                if(time <= 0)
                {
                    Console.WriteLine("Time cannot be less than or equal to 0");
                    Console.Write("Please input a new value for time: ");
                    time = (int)Console.Read();
                }
            }
        }

        public float tension()
        {
            float acceleration = (m[2] * G) / (m[2] + m[1]);
            return m[1] * acceleration;
        }

        public void solveSystem()
        {
            float currentForce = 0;
            float[] currentVelocity;
            currentVelocity = new float[3] { 0, 0, 0 };
            printPositions();
            for(int i = 0; i < time; i++)
            {

            }
        }

        private void printPositions()
        {
            Console.WriteLine("Current positions: " + "M1" + "(" + position[0, 0] + ", " + position[0, 1] + ")" + " M2" + "(" + position[1, 0] + ", " + position[1, 1] + ")" + " M2" + "(" + position[2, 0] + ", " + position[2, 1] + ")");
        }

        private float Distance(float initialVelocity, float acceleration)
        {
            return initialVelocity + acceleration / 2; //since time = 1
        }

        private float finalVelocity(float initialVelocity, float acceleration)
        {
            return initialVelocity + acceleration; //since time = 1
        }

        private float[] frictionForce()
        {
            float[] forces;
            forces = new float[3];
            for(int i = 0; i < forces.Length; i++)
            {
                forces[i] = m[i] * G;
            }
            return forces;
        }
    }
}
