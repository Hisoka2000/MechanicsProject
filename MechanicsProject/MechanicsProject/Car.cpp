#include "Car.h"
#include <cmath>

	Car::Car(int speed, float positiveAcc, float negativeAcc, float distanceToIntersection) {
		this->speed = speed;
		this->positiveAcc = positiveAcc;
		this->negativeAcc = negativeAcc;
		this->distanceToIntersection = distanceToIntersection;
	}
	int Car::getSpeed() {
		return speed;
	}
	void Car::setSpeed(int speed) {
		this->speed = speed;
	}

	float Car::getPositiveAcc() {
		return positiveAcc;
	}
	void Car::setPositiveAcc(float positiveAcc) {
		this->positiveAcc = positiveAcc;
	}

	float Car::getNegativeAcc() {
		return negativeAcc;
	}
	void Car::setNegativeAcc(float negativeAcc) {
		this->negativeAcc = negativeAcc;
	}

	float Car::getDistanceToIntersection() {
		return distanceToIntersection;
	}
	void Car::setDistanceToIntersection(float distance) {
		this->distanceToIntersection = distanceToIntersection;
	}

	float Car::positiveDistance(float time) {
		float distance = getSpeed() * time + (float)((getPositiveAcc() * sqrt(time)) / 2);
		return distance;
	}

	float Car::negativeDistance(float time) {
		float distance = getSpeed() * time + (float)((getNegativeAcc() * sqrt(time)) / 2);
		return distance;
	}