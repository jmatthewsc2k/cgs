using System;

namespace p1
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] student = new string[5];

            student[0] = "Molly";
            student[1] = "Sabba";
            student[2] = "Hatty";
            student[3] = "Beth";
            student[4] = "Jade";

            //Outputting individual elements of the array
            Console.WriteLine(student[0]);
            Console.WriteLine(student[1]);
            Console.WriteLine(student[2]);
            Console.WriteLine(student[3]);
            Console.WriteLine(student[4]);

            //Using a loop
            for(int i = 0; i <= 4; i++)
            {
                Console.WriteLine(student[i]);
            }

            Console.ReadLine();
        }
    }
}
