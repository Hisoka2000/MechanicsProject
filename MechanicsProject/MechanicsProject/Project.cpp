#include <iostream>
#include "Car.h"
#include "Intersection.h"
using namespace std;


int main() {
	float speed;
	float positiveAcc;
	float negativeAcc;
	float distanceToIntersection;
	float width;
	float duration;

	cout << "Input the cars speed in km/h: ";
	cin >> speed;
	cout << "Input the cars constant positive acceleration in m/s^2: ";
	cin >> positiveAcc;
	cout << "Input the cars constant negative acceleration in m/s^2: ";
	cin >> negativeAcc;
	cout << "Input the cars distance to the intersection in meters: ";
	cin >> distanceToIntersection;
	
	Car car(speed, positiveAcc, negativeAcc, distanceToIntersection);

	cout << "Input the width of the intersection in meters: ";
	cin >> width;
	cout << "Input the duration of the yellow light in seconds: ";
	cin >> duration;

	Intersection intersection(width, duration);

	if (car.shouldCarStop(intersection.getWidth(), intersection.getDuration())) {
		cout << "The car should start decelerating to stop";
	}
	else {
		cout << "The car should accelerate to pass the intersection";
	}
	
	
	return 0;
}
