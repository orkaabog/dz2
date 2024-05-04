using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class UniqueCharacterFinder
    {
        public static List<char> FindUniqueChars(string text)
        {
            List<char> uniqueChars = new List<char>();

            for (int i = 0; i < text.Length; i++)
            {
                int occurrenceCount = 0;

                for (int j = 0; j < text.Length; j++)
                {
                    if (text[i] == text[j])
                    {
                        occurrenceCount++;
                    }
                }

                if (occurrenceCount == 1)
                {
                    uniqueChars.Add(text[i]);
                }
            }

            return uniqueChars;
        }
    }
}
