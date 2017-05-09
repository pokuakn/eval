using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Palindrome
{
    class Program
    {
        static void Main(string[] args)
        {
           string[] dwarves = { "Gimli", "Fili", "Ilif", "Ilmig","Mark" };
            ///string[] dwarves = { "Fili", "Ilif" };
            /*foreach (string value in dwarves)
              {
                 Console.WriteLine(value);
                 Console.WriteLine(" ");
                 char[] charArry = value.ToCharArray();
                    permute(charArry, 0, charArry.Length-1);

                }*/
            
            string dwarveNames = String.Join("", dwarves);
            List<string> Palindromes = subsets.GetPalindromes(dwarveNames);
            foreach (var item in Palindromes)
            {
                Console.WriteLine("LIST: {0}", item);
            }



            /*foreach (var permutation in dwarves.GetPermutations())
            {
               
                string str = String.Join("", permutation);
                bool pal = IsPalindrome(str);
                Console.WriteLine("isPalindrome: {0}, String Permutation: {1} ", pal, str);
                //Console.WriteLine(string.Join("", permutation));
            }*/

            Console.ReadKey();
        }

        /// <summary>
        /// Permutes a given string.
        /// </summary>
        /// 
        static void permute(char[] arry, int i, int n)
        {
            
            int j;
            if (i == n)
            {
                
                //*Print Name and print if Palindrome*/
                string str = String.Join("", arry);
                bool pal = IsPalindrome(str); 
                Console.WriteLine("isPalindrome: {0}, String Permutation: {1} ", pal, str);
               ;

            }
            else
            {
                for (j = i; j <= n; j++)
                {
                    swap(ref arry[i], ref arry[j]);
                    permute(arry, i + 1, n);
                    swap(ref arry[i], ref arry[j]); //backtrack
                }
            }

           
        }

     
        static void swap(ref char a, ref char b)
        {
            char tmp;
            tmp = a;
            a = b;
            b = tmp;
        }

        /// <summary>
        /// Determines whether the string is a palindrome.
        /// </summary>
        public static bool IsPalindrome(string value)
        {
            string str = value.ToLower();
            string reverse = new string(str.ToCharArray().Reverse().ToArray());
            bool isPalindrome = reverse.Equals(str);
            return isPalindrome;
        }
          
        
    }
}
