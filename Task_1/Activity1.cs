﻿using System;
using System.Collections.Generic;

/// <summary>
/// This class is used to reverse any inputed string.
/// 
/// 1. Take any sentence in a String and reverse every word:
/// Example Input:
/// “The quick brown fox jumps over the lazy dog”
/// 
/// Example Result:
/// “dog lazy the over jumps fox brown quick The”
///
/// Current test solutions
/// When "Hello my name is John Nilson" is inputed, "Nilson John is name my Hello" is outputted.
/// </summary>
/*
 * Task 1
 * 
 * Produce code that will do reverse every word in a string like the following:
 * Example Input:
 * PRIOR Program
 *      “The quick brown fox jumps over the lazy dog”
 * POST program
 *      “dog lazy the over jumps fox brown quick The”
 */
namespace Task_1
{
    class Activity1
    {
        private String startString;
        private List<String> indiviualWords;

        public void GetInput()
        { // Save input
            Console.WriteLine("Input String to reverse");
            startString = Console.ReadLine();
        }

        public void ReverseString()
        { // Assign each word to array location
            int startIndex = 0;
            int length = 0;
            indiviualWords = new List<String>();
            for (int i = 0; i < startString.Length; i++)
            {
                if (startString[i] == ' ' && startIndex <= startString.Length)
                {
                    length = i - startIndex;
                    indiviualWords.Add(startString.Substring(startIndex, length));
                    startIndex = length + startIndex + 1;
                }
            }
            indiviualWords.Add(startString.Substring(startIndex, startString.Length - startIndex));
        }
        public void PrintReversedString()
        { // Print out array backwords
            for (int x = indiviualWords.Count - 1; x >= 0; x--)
            {
                Console.Write(indiviualWords[x] + " ");
            }
        }
    }
}