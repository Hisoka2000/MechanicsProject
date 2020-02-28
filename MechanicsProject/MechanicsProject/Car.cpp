#include "Car.h"
#include <iostream>
#include <cmath>
using namespace std;

	float Car::getSpeed() {
		return (speed * 1000)/3600;	//in m/s
	}

	void Car::setSpeed(float speed) {
		while (speed < 20 || speed > 80) {
			cout << "Speed has to be between 20 and 80 included" << endl;
			cout << "Please enter a new value: ";
			cin >> speed;
		}
		this->speed = speed;
	}

	float Car::getDistanceToIntersection() {
		return distanceToIntersection;
	}

	void Car::setDistanceToIntersection(float distanceToIntersection) {
		while (distanceToIntersection < 10 || distanceToIntersection > 150) {
			cout << "Distance has to be between 10 and 150 included" << endl;
			cout << "Please enter a new value: ";
			cin >> distanceToIntersection;
		}
		this->distanceToIntersection = distanceToIntersection;
	}

	float Car::getPositiveAcc() {
		return positiveAcc;
	}

	void Car::setPositiveAcc(float positivieAcc) {
		while (positiveAcc < 1 || positiveAcc > 3) {
			cout << "Positive acceleration has to be between 1 and 3 included" << endl;
			cout << "Please enter a new value: ";
			cin >> positiveAcc;
		}
		this->positiveAcc = positiveAcc;
	}

	float Car::getNegativeAcc() {
		return negativeAcc;
	}

	void Car::setNegativeAcc(float negativeAcc) {
		while (negativeAcc < 1 || negativeAcc > 3) {
			cout << "Negative acceleration has to be between 1 and 3 included" << endl;
			cout << "Please enter a new value: ";
			cin >> negativeAcc;
		}
		this->negativeAcc = negativeAcc;
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
