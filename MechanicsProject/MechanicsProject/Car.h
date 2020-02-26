#pragma once
class Car
{
private:
	int speed = 0;
	float positiveAcc = 0;
	float negativeAcc = 0;
	float distanceToIntersection = 0;
public:
	int getSpeed();
	void setSpeed(int speed);
	float getPositiveAcc();
	void setPositiveAcc(float positiveAcc);
	float getNegativeAcc();
	void setNegativeAcc(float negativeAcc);
	Car(int speed, float positiveAcc, float negativeAcc, float distanceToIntersection);
	float positiveDistance(float time);
	float negativeDistance(float time);
	float getDistanceToIntersection();
	void setDistanceToIntersection(float distance);
};

