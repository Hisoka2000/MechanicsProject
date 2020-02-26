#pragma once
class Intersection
{
private:
	float width = 0;
	int duration = 0;
public:
	float getWidth();
	void setWidth(float width);
	int getDuration();
	void setDuration(int duration);
	Intersection(float width, int duration);
};

