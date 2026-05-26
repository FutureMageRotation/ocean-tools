using System;

namespace OceanTools.Core
{
    public static class Logger
    {
        public static void Info(string message)
        {
            Console.WriteLine($"[OceanTools] {message}");
        }
    }
}
