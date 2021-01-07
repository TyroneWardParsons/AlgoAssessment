using System;
using System.Collections.Generic;
using System.Linq;

namespace TGS.Challenge
{
    /*
        Devise a function that checks if 1 word is an anagram of another, if the words are anagrams of
        one another return true, else return false

        "Anagram": An anagram is a type of word play, the result of rearranging the letters of a word or
        phrase to produce a new word or phrase, using all the original letters exactly once; for example
        orchestra can be rearranged into carthorse.

        areAnagrams("horse", "shore") should return true
        areAnagrams("horse", "short") should return false

        NOTE: Punctuation, including spaces should be ignored, e.g.

        horse!! shore = true
        horse  !! shore = true
        horse? heroes = true

        There are accompanying unit tests for this exercise, ensure all tests pass & make
        sure the unit tests are correct too.
    */

    public class Anagram
    {
        public bool AreAnagrams(string word1, string word2)
        {
            /* ensure that both given arguments are not null or empty */
            if (string.IsNullOrEmpty(word1) || string.IsNullOrEmpty(word2))
            {
                throw new ArgumentException();
            }

            /* create temporary list and check off found characters until either a character is not found or all are removed */
            List<char> characters = word1.ToLowerInvariant()
                .ToList();

            foreach (char c in word2)
            {
                /* ignore punctuation & whitespace */
                if (char.IsPunctuation(c) || char.IsWhiteSpace(c))
                {
                    continue;
                }

                /* try and remove the given character from remaining characters */
                if (!characters.Remove(char.ToLowerInvariant(c)))
                {
                    return false;
                }
            }

            /* return true if all characters found */
            return true;
        }
    }
}
