using System;
using System.Linq;

namespace cSharpKata.Katas
{
    public static class MergedStringChecker
    {

        public static bool isMerge(string s, string part1, string part2)
        {
            var sCharArray = s.ToCharArray(0, s.Length);

            // the indexes of each char in part one should match the indexes of s (the string)

            var part1Length = part1.Length;
            var part1Chars = part1.ToCharArray(0, part1Length);

            for (int i = 0; i < part1Length; i++)
            {
                var c1 = Array.IndexOf(sCharArray, i);
                var c2 = Array.IndexOf(part1Chars, i);

                if (c1 != c2)
                {
                    return false; // NO WAY BABY!
                }
            }

            var part2Length = part2.Length;
            var part2Chars = part2.ToCharArray(0, part2Length);

            for (int i = 0; i < part2Length; i++)
            {
                var c1 = Array.IndexOf(sCharArray, i);
                var c2 = Array.IndexOf(part2Chars, i);

                if (c1 != c2)
                {
                    return false; // GTFO
                }
            }

            // the ordering is fine, join them... and together they
            // can rule the galaxy like father and son
            var theSagaLength = part1Length + part2Length;

            var theSaga = string.Concat(part1, part2)
                .ToCharArray(0, theSagaLength);

            for (int i = 0; i < theSagaLength; i++)
            {
                var c1 = Array.IndexOf(sCharArray, i);
                var c2 = Array.IndexOf(theSaga, i);

                if (c1 != c2)
                {
                    return false; // Go home noob
                }
            }

            // final check
            for (int i = 0; i < s.Length; i++)
            {
                // sort first
                var sorted1 = string.Concat(s.OrderBy(c => c));
                var sorted2 = string.Concat(string.Concat(part1, part2).OrderBy(c => c));

                var char1 = sorted1[i];
                var char2 = sorted2[i];

                if (char1 != char2)
                {
                    // letter is missing, get rek'd
                    return false;
                }
            }

            return true;
        }
    }
}
