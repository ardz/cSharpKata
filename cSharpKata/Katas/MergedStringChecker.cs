using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace cSharpKata.Katas
{
    public static class MergedStringChecker
    {
        public static bool McMerge(string s, string part1, string part2)
        {
            int p1 = 0;
            int p2 = 0;
            
            var duplicates = new List<char>();

            for (int i = 0; i < s.Length; i++)
            {
                if (part1.Length > p1 && part1[p1] == s[i] && part2.Length > p2 && part2[p2] == s[i])
                {
                    duplicates.Add(s[i]);
                    p1++;
                    p2++;
                }
                else if (part1.Length > p1 && part1[p1] == s[i])
                {
                    p1++;
                }
                else if (part2.Length > p2 && part2[p2] == s[i])
                {
                    p2++;
                }
                else if (duplicates.Any() && s[i] == duplicates[0])
                {
                    duplicates.RemoveAt(0);
                }
                else
                {
                    return false;
                }
            }
            return p1 == part1.Length && p2 == part2.Length;
        }


        public static bool SmartAssMerge(string s, string part1, string part2)
        {
            if (s.Length != (part1.Length + part2.Length))
            {
                return false;
            }

            var leftMergeSb = new StringBuilder(s);
            var sb1 = new StringBuilder(part1);
            var sb2 = new StringBuilder(part2);

            while (leftMergeSb.Length > 0) // if it's zero stop 
            {
                int len1 = 0;
                int len2 = 0;

                for (int i = 0; i < sb1.Length; i++)
                {
                    var a = leftMergeSb[i];
                    var b = sb1[i];

                    if (a == b)
                    {
                        len1++;
                    }
                    else
                    {
                        break;
                    }
                }

                for (int i = 0; i < sb2.Length; i++)
                {
                    if (leftMergeSb[i] == sb2[i])
                    {
                        len2++;
                    }
                    else
                    {
                        break;
                    }
                }

                // if letter can't be found in either string, it's not there obvs
                // so return false
                if ((len1 == 0) && (len2 == 0))
                {
                    return false;
                }

                if (len1 > len2)
                {
                    sb1.Remove(0, 1);
                    leftMergeSb.Remove(0, 1);
                }
                else
                {
                    sb2.Remove(0, 1);
                    leftMergeSb.Remove(0, 1);
                }
            }

            if ((leftMergeSb.Length == 0) && (sb1.Length == 0) && (sb2.Length == 0))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static bool IsMerge(string s, string part1, string part2)
        {
            var sCharArray = s.ToCharArray(0, s.Length);

            var part1Length = part1.Length;
            var part1Chars = part1.ToCharArray(0, part1Length);

            var part2Length = part2.Length;
            var part2Chars = part2.ToCharArray(0, part2Length);

            if (!string.Concat(part1, part2).Equals(s))
            {
                return false;
            }

            for (int i = 0; i < part1Length; i++)
            {
                var ci1 = Array.IndexOf(sCharArray, i);
                var ci2 = Array.IndexOf(part1Chars, i);

                if (ci1 != ci2)
                {
                    return false; // NO WAY BABY!
                }
            }

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
