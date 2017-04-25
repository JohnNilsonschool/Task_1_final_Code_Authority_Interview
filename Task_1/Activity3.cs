using System;

/// <summary>
/// This class is used to find two numbers in series, which are seperated by a comma in a string.
///
/// Original problem given:
/// 3. Find the pattern "[Number1, Number2]" in any given String and get the Integer (32bit) values for Number 1 and Number2.
/// Example Input:
/// "Foo Bar[45, 65] Bash"
///
/// Example Result:
/// Number 1 = 45
/// Number2 = 66
///
/// Current test solutions
/// When "Hello I have 3 cats, and 4 dogs." is inputed, 3 and 4 are outputted.
/// </summary>

namespace Task_1
{
    class Activity3
    { // Initial values
        String initialString = string.Empty;
        String numberOneWordForm = string.Empty;
        String numberTwoWordForm = string.Empty;
        int number1, number2;
        bool passedComma = false;

        public void GetInput()
        { // Save input
            Console.WriteLine("Input a phrase with two numbers seperated by a comma");
            initialString = Console.ReadLine();
        }

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