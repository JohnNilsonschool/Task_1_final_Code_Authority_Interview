using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * This is the driver class that calls all the methods of all the activities.
 */
namespace Task_1
{
    class Program
    {
        static void Main(string[] args)
        { // Creates new program
            Program program = new Program();
            program.ChooseActivity();
        }

        private void ChooseActivity()
        { // Creates dialog to choose program
            MainMenu mainMenu = new MainMenu();

            mainMenu.PrintInstructions();
            mainMenu.GetActivity();
            String selection = mainMenu.GetSelection();
            switch (selection)
            {
                // Activity 1
                case "1":
                    Console.WriteLine("You selected: 1: Reverse a string");
                    Activity1 activity1 = new Activity1();
                    activity1.GetInput();
                    activity1.ReverseString();
                    activity1.PrintReversedString();
                    Console.WriteLine();
                    ChooseActivity();
                    break;
                // Activity 2
                case "2":
                    Console.WriteLine("You selected: 2: Exchange value of varibles");
                    Activity2 activity2 = new Activity2();
                    activity2.PrintValues();
                    activity2.FlipValues();
                    activity2.PrintReversedValues();
                    Console.WriteLine();
                    ChooseActivity();
                    break;
                // Activity 1
                case "3":
                    Console.WriteLine("You selected: 3: Exchange value of varibles");
                    Activity3 activity3 = new Activity3();
                    activity3.GetInput();
                    activity3.FindValues();
                    activity3.PrintValues();
                    Console.WriteLine();
                    ChooseActivity();
                    break;
            }
        }
    }
}
