using System.Runtime.InteropServices;

namespace HelloNativeLibrary;

class Program
{
    unsafe internal delegate void HelloCallback(int result);

    [DllImport("hello_callback")] unsafe extern internal static void helloCallback(int number, string str, HelloCallback callback);

    static void Main()
    {
        try
        {
            Console.WriteLine("from C#: HelloNativeLibrary.Main()");

            static void testCallback(int result)
            {
                Console.WriteLine($"from C#: Received {result} from C library callback");
            }

            // This completely blows up with the following, the native printf() is never hit:
            // System.OutOfMemoryException: Insufficient memory to continue the execution of the program.
            helloCallback(123, "abc", testCallback);

            Console.WriteLine("from C#: Done!");
        }
        catch (Exception exception)
        {
            Console.Error.WriteLine(exception);
        }
    }
}