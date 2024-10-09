using System;

namespace ExtensionMethodDemo
{
    public static class Extensions
    {
        public static void PrintToConsole(this string message)
        {
            Console.WriteLine(message);
        }
    }

}
