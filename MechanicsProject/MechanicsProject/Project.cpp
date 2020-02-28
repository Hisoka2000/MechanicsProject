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

	Car car;
	Intersection intersection;

	cout << "Input the cars speed in km/h: ";
	cin >> speed;
	car.setSpeed(speed);
	cout << "Input the cars constant positive acceleration in m/s^2: ";
	cin >> positiveAcc;
	car.setPositiveAcc(positiveAcc);
	cout << "Input the cars constant negative acceleration in m/s^2: ";
	cin >> negativeAcc;
	car.setNegativeAcc(negativeAcc);
	cout << "Input the cars distance to the intersection in meters: ";
	cin >> distanceToIntersection;
	car.setDistanceToIntersection(distanceToIntersection);
	
	cout << "Input the width of the intersection in meters: ";
	cin >> width;
	intersection.setWidth(width);
	cout << "Input the duration of the yellow light in seconds: ";
	cin >> duration;
	intersection.setDuration(duration);


	if (car.shouldCarStop(intersection.getWidth(), intersection.getDuration())) {
		cout << "The car should start decelerating to stop";
	}
	else {
		cout << "The car should accelerate to pass the intersection";
	}
	
	
	return 0;
}
