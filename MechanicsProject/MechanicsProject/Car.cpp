#include "Car.h"
#include <cmath>

	Car::Car(float speed, float positiveAcc, float negativeAcc, float distanceToIntersection) {
		this->speed = speed;
		this->positiveAcc = positiveAcc;
		this->negativeAcc = negativeAcc;
		this->distanceToIntersection = distanceToIntersection;
	}
	float Car::getSpeed() {
		return (speed * 1000)/3600;	//in m/s
	}

	float Car::getPositiveAcc() {
		return positiveAcc;
	}

	float Car::getNegativeAcc() {
		return negativeAcc;
	}

	float Car::getDistanceToIntersection() {
		return distanceToIntersection;
	}

	float Car::positiveDistance(float time) {
		float distance = getSpeed() * time + (float)((getPositiveAcc() * sqrt(time)) / 2);
		return distance;
	}

	//v^2 = v0^2 + 2ax0 => Since (final velocity) v = 0, to get distance when decelerating
	float Car::negativeDistance() {
		float distance = -((sqrt(getSpeed())) / (2 * negativeAcc));
		return distance;
	}

	bool Car::shouldCarStop(float intersectionWidth, float duration) {
		//If he can manage to pass in time or if there is no way he can stop till the intersection, can shouldnt stop. Else the car should stop
		if ((positiveDistance(duration) >= distanceToIntersection + intersectionWidth) || (negativeDistance() > distanceToIntersection)) {
			return false;
		}
		else {
			return true;
		}

	}
