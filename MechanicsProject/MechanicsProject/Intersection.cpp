#include "Intersection.h"
#include <iostream>
using namespace std;


float Intersection::getWidth() {
	return width;
};

void Intersection::setWidth(float width) {
	while (width < 5 || width > 20) {
		cout << "Width needs to be between 5 and 20 included" << endl;
		cout << "Please enter another value: ";
		cin >> width;
	}
	this->width = width;
}

float Intersection::getDuration() {
	return duration;
};

void Intersection::setDuration(float duration) {
	while (duration < 2 || duration > 5) {
		cout << "Duration needs to be between 2 and 5 included" << endl;
		cout << "Please enter another value: ";
		cin >> duration;
	}
	this->duration = duration;
}
