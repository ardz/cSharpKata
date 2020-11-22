using System.Collections.Generic;
using System.Linq;

namespace cSharpKata.Katas
{
    public class ArrayDiff
    {
        public static int[] CalculateDiff(int[] a, int[] b)
        {
            HashSet<int> hash = new HashSet<int>(b);

           return a.Where(_ => !hash.Contains(_)).ToArray();
        }
    }
}
