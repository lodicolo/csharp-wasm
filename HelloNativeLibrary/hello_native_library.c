#include <stdio.h>

#ifdef __cplusplus
extern "C"
{
#endif

    int helloNativeLibrary(int number, const char *cstr)
    {
        printf("from C: helloNativeLibrary(%d, \"%s\")\n", number, cstr);
        return 456;
    }

#ifdef __cplusplus
}
#endif
