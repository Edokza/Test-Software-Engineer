using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_Software_Engineer
{
    public class AlienToInt
    {
        public int Converting(string alien)
        {
            if(string.IsNullOrEmpty(alien))
                return 0;

            return ConvertAlienToInt(alien);
        }

        private readonly Dictionary<char, int> _map = new Dictionary<char, int>
        {
            { 'A', 1 },
            { 'B', 5 },
            { 'Z', 10 },
            { 'L', 50 },
            { 'C', 100 },
            { 'D', 500 },
            { 'R', 1000 }
        };

        public int ConvertAlienToInt(string alien)
        {
            if (string.IsNullOrEmpty(alien))
                return 0;

            int total = 0;

            for (int i = 0; i < alien.Length; i++)
            {
                int current = _map[alien[i]];

                if (i + 1 < alien.Length)
                {
                    int next = _map[alien[i + 1]];

                    if (current < next)
                        total -= current;
                    else
                        total += current;
                }
                else
                {
                    total += current;
                }
            }

            return total;
        }
        public bool IsAlienFormat(string input)
        {
            char[] validChars = { 'A', 'B', 'Z', 'L', 'C', 'D', 'R' };

            return input.ToUpper().All(c => validChars.Contains(c));
        }

    }
}
