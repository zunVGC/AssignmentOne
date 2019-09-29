#include "SimpleClass.h"

int SimpleClass::SimpleFunction()
{
	return 1;
}

void SimpleClass::readX(float _myX)
{
	myX = _myX;
}

void SimpleClass::readY(float _myY)
{
	myY = _myY;
}

void SimpleClass::readZ(float _myZ)
{
	myZ = _myZ;
}

float SimpleClass::reX()
{
	return myX;
}

float SimpleClass::reY()
{
	return myY;
}

float SimpleClass::reZ()
{
	return myZ;
}

void SimpleClass::writePosition()
{
	ofstream file;
	file.open("POSITION.txt");
	file << myX << " " << myY << " " << myZ << endl;
	file.close();
}

void SimpleClass::readPosition()
{
	ifstream inFile;
	inFile.open("POSITION.txt");


	while (inFile >> myX >> myY >> myZ)
	{

	}

	inFile.close();
}