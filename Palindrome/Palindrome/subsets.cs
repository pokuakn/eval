using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Palindrome
{
    class subsets
    {
        public static List<string> GetPalindromes(string source) 
        {
            List<string> subsets = new List<string>();
            for (int i = 0; i < source.Length - 1; i++)
            {
                for (int j = i + 1; j <= source.Length; j++)
                {
                    if (j - i > 1 && source[j - 1] == source[i])
                    {
                        string currentSubset = source.Substring(i, j - i);
                        if (IsPalindrome1(currentSubset))
                        {
                            subsets.Add(currentSubset);
                        }
                    }
                }
            }
            return subsets;
        }
        /// <summary>
        /// Determines whether the string is a palindrome.
        /// </summary>
        public static bool IsPalindrome1(string value)
        {
            string str = value.ToLower();
            string reverse = new string(str.ToCharArray().Reverse().ToArray());
            bool isPalindrome = reverse.Equals(str);
            return isPalindrome;
        }
        /// <summary>
        /// Determines whether the string is a palindrome.
        /// </summary>
        private static bool IsPalindromeSet(string input)
        {
            return !input.Where((t, i) => t != input[input.Length - 1 - i]).Any();
        }
    }
}
