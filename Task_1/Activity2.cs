using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
