using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
///  This class finds a pattern of numbers seperated by a comma in a string.
/// </summary>

/* Original problem given:
 * 
 * 3. Find the pattern “[Number1, Number2]” in any given String and get the Integer (32bit) values for Number1 and Number2.
 *
 * Example Input:
 * “Foo Bar[45, 66] Bash”
 *
 * Example Result:
 * Number1 = 45
 * Number2 = 6
 */

/*
 * Current test returns: 
 * error
 * 
 * when the following is inputed
 * The to random values for this random sentence are [45,66]. There you go. 
 */
namespace Task_1
{
    class Activity3
    {
        // Initial values
        String initialString = "The to random values for this random sentence are [45, 66]. There you go.";
        String numberOneWordForm = string.Empty;
        String numberTwoWordForm = string.Empty;
        int number1, number2;
        bool passedComma = false;

        public void FindValues()
        { // Finds the 2 given values
            for (int i = 0; i < initialString.Length; i++)
            {
                // Consider Refactor
                if (initialString[i].Equals('0') ||
                    initialString[i].Equals('1') ||
                    initialString[i].Equals('2') ||
                    initialString[i].Equals('3') ||
                    initialString[i].Equals('4') ||
                    initialString[i].Equals('5') ||
                    initialString[i].Equals('6') ||
                    initialString[i].Equals('7') ||
                    initialString[i].Equals('8') ||
                    initialString[i].Equals('9'))
                {
                    if (passedComma == false)
                    {
                        numberOneWordForm += initialString[i];
                    }
                    else
                    {
                        numberTwoWordForm += initialString[i];
                    }
                }
                if (initialString[i].Equals(','))
                {
                    passedComma = true;
                }
            }
            ConvertValues();
        }

        private void ConvertValues()
        { // Converts the two values
            number1 = int.Parse(numberOneWordForm);
            number2 = int.Parse(numberTwoWordForm);
        }


        public void PrintValues()
        { // Prints the two values
            Console.WriteLine(number1);
            Console.WriteLine(number2);
        }
    }
}