using System.Linq;

namespace cSharpKata.Katas
{
    public class CharacterCounting
    {
        public static int DuplicateCount(string str)
        {
            var count = (from c in str.ToLower() // c = ["a","b", "c"] <= c looks like this
                         group c by c // = group by each unique char
                         into grp // project into another var grp
                         where grp.Count() > 1 // count each group where the group contains > 1
                         select grp.Key).Count(); // total number of groups where group > 1

            return count;
        }
    }
}
