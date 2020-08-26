using System;

namespace ConsoleAppBreakingChange
{
    class Program
    {
        static void Main(string[] args)
        {
            var c = new ClassLibraryWithWinRT.Class1();
            Console.WriteLine(c.Value);
        }
    }
}
