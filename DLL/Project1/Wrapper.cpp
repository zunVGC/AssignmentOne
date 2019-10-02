#include "Wrapper.h"

SimpleClass simpleClass;
int SimpleFunction()
{
	return simpleClass.SimpleFunction();
}

void readX(float xP)
{
	return simpleClass.readX(xP);
}

void readY(float yP)
{
	return simpleClass.readY(yP);
}

void readZ(float zP)
{
	return simpleClass.readZ(zP);
}

float reX()
{
	return simpleClass.reX();
}

float reY()
{
	return simpleClass.reY();
}

float reZ()
{
	return simpleClass.reZ();
}

void writePosition()
{
	return simpleClass.writePosition();
}

PLUGIN_API void readPosition()
{
	return simpleClass.readPosition();
}
