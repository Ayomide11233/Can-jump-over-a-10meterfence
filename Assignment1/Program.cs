// See https://aka.ms/new-console-template for more information
using System;

namespace JumpOverFence
{
    class Program
    {
        static void Main(string[] args)
        {
            
            string[] studentNames = { "Tobi", "Ayo", "Deborah", "David", "Pelumi", "Frank", "Grace", "Hannah", "John", "Joseph" };
            double[] studentHeights = { 5.0, 4.0, 4.2, 3.9, 2.6, 4.6, 1.8, 4.9, 3.7, 5.2 };

            Console.WriteLine("Student heights:");
            for (int i = 0; i < studentNames.Length; i++)
            {
                Console.WriteLine($"{studentNames[i]}: {studentHeights[i]} meters");
            }

            bool found = false;
            for (int i = 0; i < studentHeights.Length - 1; i++)
            {
                for (int j = i + 1; j < studentHeights.Length; j++)
                {
                    if (studentHeights[i] + studentHeights[j] >= 10)
                    {
                        Console.WriteLine($"{studentNames[i]} and {studentNames[j]} can jump over the 10-meter fence.");
                        found = true;
                    }
                    else
                    {
                        //Console.WriteLine($"{studentNames[i]} and {studentNames[j]} can't jump over the 10-meter fence and they are too short.");
                    }
                }
            }

            if (!found)
            {
                Console.WriteLine("No two students can jump over the 10-meter fence.");
            }
        }
    }
}
