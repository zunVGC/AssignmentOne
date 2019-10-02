#pragma once

#include "PluginSettings.h"

class PLUGIN_API SimpleClass
{
public:
	int SimpleFunction();
	void readX(float);
	void readY(float);
	void readZ(float);
	float reX();
	float reY();
	float reZ();
	void writePosition();
	void readPosition();
};