using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectMechanics
{
    class Car
    {
		private float speed = 0;
		private float positiveAcc = 0;
		private float negativeAcc = 0;
		private float distanceToIntersection = 0;
		private float maxSpeed = 0;

		public float MaxSpeed
		{
			get
			{
				return maxSpeed;
			}

			set
			{
				maxSpeed = value;
				if(maxSpeed != 0)
				{
					while (maxSpeed < 50 || maxSpeed > 100)
					{
						Console.WriteLine("Max speed has to be between 50 and 100 included");
						Console.Write("Please enter a new value: ");
						maxSpeed = float.Parse(Console.ReadLine());
					}
				}
			}
		}

		public float Speed
		{
			get
			{
				return (speed * 1000) / 3600;   //in m/s
			}

			set
			{
				speed = value;
				while (speed < 20 || speed > 80)
				{
					Console.WriteLine("Speed has to be between 20 and 80 included");
					Console.Write("Please enter a new value: ");
					speed = float.Parse(Console.ReadLine());
				}
			}
		}

		public float DistanceToIntersection
		{
			get
			{
				return distanceToIntersection;
			}

			set
			{
				distanceToIntersection = value;
				while (distanceToIntersection < 10 || distanceToIntersection > 150)
				{
					Console.WriteLine("Distance to intersection has to be between 10 and 150 included");
					Console.Write("Please enter a new value: ");
					distanceToIntersection = float.Parse(Console.ReadLine());
				}
			}
		}

		public float PositiveAcc
		{
			get
			{
				return positiveAcc;
			}

			set
			{
				positiveAcc = value;
				while (positiveAcc < 1 || positiveAcc > 3)
				{
					Console.WriteLine("Positive acceleration has to be between 1 and 3 included");
					Console.Write("Please enter a new value: ");
					positiveAcc = float.Parse(Console.ReadLine());
				}
			}
		}

		public float NegativeAcc
		{
			get
			{
				return negativeAcc;
			}

			set
			{
				negativeAcc = value;
				while (negativeAcc < 1 || negativeAcc > 3)
				{
					Console.WriteLine("Negative acceleration has to be between 1 and 3 included");
					Console.Write("Please enter a new value: ");
					negativeAcc = float.Parse(Console.ReadLine());
				}
			}
		}

		public float positiveDistance(float time, float acceleration)
		{
			float distance = Speed * time + ((acceleration * (time * time)) / 2);
			return distance;
		}

		//v^2 = v0^2 + 2ax0 => Since (final velocity) v = 0, to get distance when decelerating
		public float distanceTillV(float V)
		{
			float distance = ((V * V) - (Speed * Speed)) / (2 * NegativeAcc);
			return distance;
		}

		public bool shouldCarStop(float intersectionWidth, float duration)
		{
			//If he can manage to pass in time or if there is no way he can stop till the intersection, can shouldnt stop. Else the car should stop
			if (maxSpeed != 0)
			{
				float distanceTillConstant = distanceTillV(maxSpeed);
				float remainingTime = (maxSpeed - Speed) / PositiveAcc;
				if (distanceTillConstant + maxSpeed * remainingTime >= DistanceToIntersection + intersectionWidth || ((distanceTillV(0)) > DistanceToIntersection))
				{
					return true;
				}
				else
				{
					return false;
				}
			}
			else if ((positiveDistance(duration, PositiveAcc) >= DistanceToIntersection + intersectionWidth) || ((distanceTillV(0)) > DistanceToIntersection))
			{
				return false;
			}
			else
			{
				return true;
			}
		}

		public float currentSpeed(float initialSpeed, float time, float acceleration)
		{
			return initialSpeed + acceleration * time;
		}
	}
}
