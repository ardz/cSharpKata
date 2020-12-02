using System;
using System.Linq;

namespace cSharpKata.Katas
{
    public static class MergedStringChecker
    {

        public static bool IsMerge(string s, string part1, string part2)
        {
            var sCharArray = s.ToCharArray(0, s.Length);

            // the indexes of each char in part one should match the indexes of s (the string)

            var part1Length = part1.Length;
            var part1Chars = part1.ToCharArray(0, part1Length);

            for (int i = 0; i < part1Length; i++)
            {
                var ci1 = Array.IndexOf(sCharArray, i);
                var ci2 = Array.IndexOf(part1Chars, i);

                if (ci1 != ci2)
                {
                    return false; // NO WAY BABY!
                }
            }

            var part2Length = part2.Length;
            var part2Chars = part2.ToCharArray(0, part2Length);

            for (int i = 0; i < part2Length; i++)
            {
                var ci1 = Array.IndexOf(sCharArray, i);
                var ci2 = Array.IndexOf(part2Chars, i);

                if (ci1 != ci2)
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
                var ci1 = Array.IndexOf(sCharArray, i);
                var ci2 = Array.IndexOf(theSaga, i);

                if (ci1 != ci2)
                {
                    return false; // Go home noob
                }
            }

            // final check
            // sort first
            var sorted1 = string.Concat(s.OrderBy(c => c));
            var sorted2 = string.Concat(string.Concat(part1, part2).OrderBy(c => c));
            
            for (int i = 0; i < s.Length; i++)
            {
                var char1 = sorted1[i];
                var char2 = sorted2[i];

                if (char1 != char2)
                {
                    // letter is missing, get rek'd
                    return false;
                }

                // no wait, it's not the final check, because this kata is bullshit:
                if (sorted1[i] != sorted2[i])
                {
                    return false;
                }
            }

            // yes, but no, but yes, this kata is still bullshit:
            if (sorted1.Length != sorted2.Length)
            {
                return false;
            }

            return true;
        }
    }
}
