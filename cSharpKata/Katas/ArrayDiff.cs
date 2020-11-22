using System.Collections.Generic;
using System.Linq;

namespace cSharpKata.Katas
{
    public class ArrayDiff
    {
        public static int[] CalculateDiff(int[] a, int[] b)
        {
            return a.Where(_ => !b.Contains(_)).ToArray();
        }
    }
}
