using System.Runtime.InteropServices;

namespace HelloNativeLibrary;

class Program
{
    [DllImport("hello_native_library")] unsafe extern internal static int helloNativeLibrary(int number, string str);

    static void Main()
    {
        Console.WriteLine("from C#: HelloNativeLibrary.Main()");

        var result = helloNativeLibrary(123, "abc");
        Console.WriteLine($"from C#: Received {result} from C library");
    }
}