using System;

namespace app
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"Hello {System.Environment.GetEnvironmentVariable("USER")}! I'm {System.Environment.MachineName} and I'm talking to you from {System.IO.Directory.GetCurrentDirectory()}");
        }
    }
}
