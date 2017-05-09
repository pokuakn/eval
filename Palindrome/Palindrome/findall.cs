using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Palindrome
{
    class findall
    {
        public static void main(string[] args)
        {
            FindAllPalindromes finder = new FindAllPalindromes();
            finder.printAllPalindromes("abcddcbaABCDEDCBA");
        }

        public void printAllPalindromes(string inputText)
        {
            if (inputText == null)
            {
                Console.WriteLine("Input cannot be null!");
                return;
            }
            if (inputText.length() <= 2)
            {
                Console.WriteLine("Minimum three characters should be present
            }

            //ODD Occuring Palindromes
            int len = inputText.length();
            for (int i = 1; i < len - 1; i++)
            {
                for (int j = i - 1, k = i + 1; j >= 0 && k < len; j--, k++)
                {
                    if (inputText.charAt(j) == inputText.charAt(k))
                    {
                        System.out.println(inputText.subSequence(j, k + 1));
                    }
                    else
                    {
                        break;
                    }
                }
            }

        }
}
