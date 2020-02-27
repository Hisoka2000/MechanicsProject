#pragma once
class Intersection
{
private:
	float width = 0.0f;
	float duration = 0.0f;
public:
	float getWidth();
	float getDuration();
	Intersection(float width, float duration);
};

