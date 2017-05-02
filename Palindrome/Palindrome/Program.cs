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
            string[] dwarves = { "Gimli", "Fili", "Ilif", "Ilmig", "Mark" };
          
            foreach (string value in dwarves)
            {
                Console.WriteLine(" ");
                Console.WriteLine(" ");
              
                char[] charArry = value.ToCharArray();
                permute(charArry, 0, charArry.Length-1);
             
            }
            
            
            Console.ReadKey();
        }
      
        static void permute(char[] arry, int i, int n)
        {
            int j;
            if (i == n)
            {
                //Print Name and print if Palindrome
                string str = String.Join("", arry);
                bool pal = IsPalindrome(str);
                Console.WriteLine("isPalindrome: {0}, String Permutation: {1} ", pal, str);
              
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
            int min = 0;
            int max = value.Length - 1;
            while (true)
            {
                if (min > max)
                {
                    return true;
                }
                char a = value[min];
                char b = value[max];
                if (char.ToLower(a) != char.ToLower(b))
                {
                    return false;
                }
                min++;
                max--;
            }
        }
    }
}
