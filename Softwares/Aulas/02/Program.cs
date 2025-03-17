using System;

namespace Aulas._02
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            if(args.GetValues(0) > 0)
                Console.WriteLine(args.GetValues(0));
            else
                Console.WriteLine("No arguments passed.");
        }
    }
}

