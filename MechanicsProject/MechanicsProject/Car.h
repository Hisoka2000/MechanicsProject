#pragma once
class Car
{
private:
	float speed = 0;
	float positiveAcc = 0;
	float negativeAcc = 0;
	float distanceToIntersection = 0;
public:
	float getSpeed();
	float getPositiveAcc();
	float getNegativeAcc();
	float positiveDistance(float time);
	float negativeDistance();
	float getDistanceToIntersection();
	bool shouldCarStop(float intersectionWidth, float duration);

	Car(float speed, float positiveAcc, float negativeAcc, float distanceToIntersection);
};

