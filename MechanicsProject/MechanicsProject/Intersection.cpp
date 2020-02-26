#include "Intersection.h"

Intersection::Intersection(float width, int duration) {
	this->width = width;
	this->duration = duration;
}

float Intersection::getWidth() {
	return width;
};
void Intersection::setWidth(float width) {
	this->width = width;
};

int Intersection::getDuration() {
	return duration;
};

void Intersection::setDuration(int duration) {
	this->duration = duration;
};