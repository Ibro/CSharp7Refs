using System;

namespace CSharp7Refs
{
    public class RefLocals
    {      
        public static void PrintPoints()
        {
            int points = 15;

            ref int refToPoints = ref points;

            refToPoints = 125;

            Console.WriteLine($"Points: {points}");
        }
    }
}