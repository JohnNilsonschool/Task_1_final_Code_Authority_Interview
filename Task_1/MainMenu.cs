using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_1
{
    class MainMenu
    {
        private String selection;
        public void PrintInstructions()
        {
            Console.WriteLine("Choose from an option below. Simply type" +
                "the number you would like to use followed by enter.");
            Console.WriteLine("1: Reverse a string" + "\n" +
                              "2: Exchange value of varibles" + "\n" +
                              "3: Find value pairs in string");
        }
        public void GetActivity()
        {
            selection = Console.ReadLine();
        }
        public String GetSelection()
        {
            return selection;
        }

    }
}
