using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codewars.CodeWars
{
    public class Palindrome
    {
        public bool IsPalindromeLong(string str)
        {
            str = str.ToLower();

            int left = 0;
            int right = str.Length - 1;

            while (left < right)
            {
                if (str[left] != str[right])
                {
                    return false;
                }

                left++;
                right--;
            }

            return true;
        }

        public bool IsPalindromeShort(string str)
        {
            str = str.ToLower();

            return str.SequenceEqual(str.Reverse());
        }
    }
}
