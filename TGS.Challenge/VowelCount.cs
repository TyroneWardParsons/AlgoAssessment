using System;
using System.Linq;

namespace TGS.Challenge
{
    /*
        Devise a function that takes a string & returns the number of 
        vowels (aeiou) in that string.

        "Hi there!" = 3
        "What do you mean?"  = 6

        There are accompanying unit tests for this exercise, ensure all tests pass & make
        sure the unit tests are correct too.
    */

    public class VowelCount
    {
        /* list of lowercase vowels */
        private readonly string vowels = "aeiou";

        public int Count(string value)
        {
            /* ensure given value is not empty */
            if (string.IsNullOrEmpty(value))
            {
                throw new ArgumentException();
            }

            /* return the count of vowels in the given string */
            return value.Count(c => IsVowel(c));
        }

        /* checks if the given character is a vowel */
        private bool IsVowel(char c)
        {
            return vowels.Contains(char.ToLowerInvariant(c));
        }
    }
}
