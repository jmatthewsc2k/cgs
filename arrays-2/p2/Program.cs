using System;

namespace p2
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = new int[3];

            numbers[0] = 5;
            numbers[1] = 10;
            numbers[2] = 15;

            //Declare variable total and set to 0
            int total = 0;

            //Using a for loop you can add them together
            for(int i =0; i < 3; i++)
            {
                total = total + numbers[i];
            }

            //Output the total
            Console.WriteLine($"The numbers added together are: {total}");

            Console.ReadLine();
        }
    }
}
