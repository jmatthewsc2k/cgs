using System;

namespace _3
{
    class Program
    {
        static void Main(string[] args)
        {
            greeting("Allan",true);
            Console.WriteLine("\r\n");
            greeting("Bill",false);
            Console.ReadLine();
        }
        
        public static void greeting(string firstname,bool liked)
        {
            Console.WriteLine($"Hello, {firstname}");
            if (liked == true)
            {
                Console.WriteLine("Nice to meet you! ");
            }
            else
            {
                Console.WriteLine("I don't like you - go away. ");
            }
        }
    }
}
