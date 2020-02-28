#pragma once
class Car
{
private:
	float speed = 0;
	float positiveAcc = 0;
	float negativeAcc = 0;
	float distanceToIntersection = 0;
	float maxSpeed = 0;
public:
	float getSpeed();
	void setSpeed(float speed);
	float getPositiveAcc();
	void setPositiveAcc(float positiveAcc);
	float getNegativeAcc();
	void setNegativeAcc(float negativeAcc);
	float getDistanceToIntersection();
	void setDistanceToIntersection(float distance);
	float getMaxSpeed();
	void setMaxSpeed(float maxSpeed);

	float positiveDistance(float time);
	float negativeDistance();
	bool shouldCarStop(float intersectionWidth, float duration);
};

