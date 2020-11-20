using System.Linq;

namespace cSharpKata.Katas
{
    public class EqualSidesArray
    {
        public static int FindEvenIndex(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                var leftTake = arr.Take(i);
                var leftTotal = leftTake.Sum();

                var rightTake = arr.Skip(i + 1);
                var rightTotal = rightTake.Sum();

                if (leftTotal == rightTotal)
                {
                    return i;
                }
            }

            return -1;
        }
    }
}
