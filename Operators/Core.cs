using System;
using Ihm;

namespace Operators
{
    class Core
    {
        
        public static int GenerateRandomNumber(Random rand, int[] terms, int min, int max, int count)
        {
                int term = rand.Next(1, 11);
                while (Array.IndexOf(terms, term) > -1)
                {
                    term = rand.Next(1, 11);
                }
                terms[count] = term;
                return term;
        }

    }
}