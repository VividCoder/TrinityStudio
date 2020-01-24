// VideoNative.cpp : Defines the exported functions for the DLL.
//

#include "framework.h"
#include "VideoNative.h"


// This is an example of an exported variable
VIDEONATIVE_API int nVideoNative=0;

// This is an example of an exported function.
VIDEONATIVE_API int fnVideoNative(void)
{
    return 0;
}

// This is the constructor of a class that has been exported.
CVideoNative::CVideoNative()
{
    return;
}
