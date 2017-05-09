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
            
            //Change string to all lowercase and eliminate any case sensitivity.
            string dwarveNames = String.Join("", dwarves).ToLower();
            
            List<string> Palindromes = subsets.GetPalindromes(dwarveNames);

            foreach (var item in Palindromes)
            {
                Console.WriteLine("LIST: {0}", item);
            }

            Console.ReadKey();
        }

        
    }
}
