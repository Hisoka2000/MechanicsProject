#include "Intersection.h"

Intersection::Intersection(float width, float duration) {
	this->width = width;
	this->duration = duration;
}

float Intersection::getWidth() {
	return width;
};

float Intersection::getDuration() {
	return duration;
};
