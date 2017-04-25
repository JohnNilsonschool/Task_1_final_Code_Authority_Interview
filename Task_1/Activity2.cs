using System;

/// <summary>
/// This class flips exchanges the value of varibles without creating any new varibles.
/// 
/// Original problem given:
/// 2. Define two Integer (32bit) variables and values of X=72 and Y=59, now swap the values of X and Y without declaring any new variables, use only the two existing X and Y variables.
/// Example Input:
/// X = 72
/// Y = 59
/// 
/// Example Result:
/// X = 59
/// Y = 72
/// 
/// Current test solution outputs 72 and 59
/// </summary>

namespace Task_1
{
    class Activity2
    {
        // Initial values
        private int x = 72;
        private int y = 59;

        public void PrintValues()
        { // Print values
            Console.WriteLine("X is assigned: " + x);
            Console.WriteLine("Y is assigned: " + y);
        }

        public void FlipValues()
        { // Flipping values
            x = x + y;
            y = x - y;
            x = x - y;
        }

        public void PrintReversedValues()
        { // Print reversed values
            Console.WriteLine("X is assigned: " + x);
            Console.WriteLine("Y is assigned: " + y);
        }
    }
}
