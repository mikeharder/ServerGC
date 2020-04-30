using System;
using System.Runtime;

namespace dotnetapp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"GCSettings.IsServerGC: {GCSettings.IsServerGC}");
        }
    }
}
