using System.Collections.Generic;
using System.Linq;

namespace cSharpKata.Katas
{
    public class ArrayDifference
    {
        public static int[] Calculate(int[] a, int[] b)
        {
            return a.Where(_ => !b.Contains(_)).ToArray();
        }
    }
}
