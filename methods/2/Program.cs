using System;

namespace _2
{
    class Program
    {
        static void Main(string[] args)
        {
            greeting("Alice");
            greeting("Tayyiba");
            Console.ReadLine();
        }

        public static void greeting(string name)
        {
            Console.WriteLine($"Hello {name}");
            Console.WriteLine("Pleased to meet you.");
        }
    }
}
