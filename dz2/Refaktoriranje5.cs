using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class PalindromeFinder
    {
        public List<string> FindPalindromes(List<string> strings)
        {
            List<string> palindromes = new List<string>();

            if (strings == null)
                return palindromes;

            foreach (string str in strings)
            {
                string cleanedString = str.Replace(" ", "").ToLower();
                string reversedString = new string(cleanedString.Reverse().ToArray());

                if (cleanedString.Equals(reversedString))
                {
                    palindromes.Add(str);
                }
            }

            return palindromes;
        }
    }
}
