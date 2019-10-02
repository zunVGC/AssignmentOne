#pragma once
#include "PluginSettings.h"
#include "SimpleClass.h"

#ifdef __cplusplus
extern "C"
{
#endif
	// Put your functions here
	PLUGIN_API int SimpleFunction();
	PLUGIN_API void readX(float);
	PLUGIN_API void readY(float);
	PLUGIN_API void readZ(float);
	PLUGIN_API float reX();
	PLUGIN_API float reY();
	PLUGIN_API float reZ();
	PLUGIN_API void writePosition();
	PLUGIN_API void readPosition();
#ifdef __cplusplus
}
#endif