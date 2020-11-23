using System.Text.RegularExpressions;

namespace cSharpKata.Katas
{
    public class CamelConvertor
    {
        public static string ToCamelCase(string str)
        {
            var words = str.Split('-', '_');

            var camelString = string.Empty;

            for (int i = 0; i < words.Length; i++)
            {
                var word = words[i];
                var camelWord = string.Empty;

                if (i == 0)
                {
                    camelString += word;
                    continue;
                }
                
                camelWord = char.ToUpper(word[0]) + word[1..];

                camelString += camelWord;
            }

            return camelString;
        }

        public static string SmartAss(string str)
        {
            // once you've got more than three words this approach fails

            var foo = Regex.Replace(str, @"[_-](\w)", 
                m => m.Groups[1].Value.ToUpper());

            return foo;
        }

    }
}
