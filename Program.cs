using System;

namespace _01.__SoftUni_Reception
{
    class Program
    {
        static void Main(string[] args)
        {
            int first = int.Parse(Console.ReadLine());
            int second = int.Parse(Console.ReadLine());
            int third = int.Parse(Console.ReadLine());
            int allStudents = int.Parse(Console.ReadLine());
            int sum = 0;
            int hourCounter = 0;
            int all = 0;

            while (all <= allStudents)
            {
                if (all == allStudents)
                {
                    break;
                }
                hourCounter++;
                if (hourCounter % 4 == 0)
                {
                    
                    continue;
                }

                sum = first + second + third;
                all += sum;
            }

            Console.WriteLine($"Time needed: {hourCounter}h.");
        }
    }
}
