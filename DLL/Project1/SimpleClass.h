#pragma once

#include "PluginSettings.h"
#include <iostream>
#include <fstream> 

using namespace std;

class PLUGIN_API SimpleClass
{
public:
	int SimpleFunction();
	float myX;
	float myY;
	float myZ;
	void readX(float);
	void readY(float);
	void readZ(float);
	float reX();
	float reY();
	float reZ();
	void writePosition();
	void readPosition();
};