using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codewars.CodeWars
{
    internal class Vowel
    {
        public static int GetVowelCount(string str)
        {
            //int count = 0;
            //string vowels = "aeiou";

            //foreach (char c in str)
            //{
            //    // Check if the character is a vowel and not a space
            //    if (vowels.Contains(c) && c != ' ')
            //    {
            //        count++;
            //    }
            //}

            //return count;

            string vowels = "aeiou";
            return str.Count(c => vowels.Contains(c) && c != ' ');
        }
    }
}
