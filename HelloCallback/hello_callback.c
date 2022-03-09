#include <stdio.h>

#ifdef __cplusplus
extern "C"
{
#endif

    typedef void (*hello_callback)(int result);

    void helloCallback(int number, const char *cstr, hello_callback callback)
    {
        printf("from C: helloCallback(%d, \"%s\")\n", number, cstr);
        callback(456);
    }

#ifdef __cplusplus
}
#endif
