using cSharpKata.Katas;
using Xunit;

namespace KataTests
{
    public class Tests
    {

        /// <summary>
        /// At a job interview, you are challenged to write an algorithm to check if a given string, s, 
        /// can be formed from two other strings, part1 and part2.

        /// The restriction is that the characters in part1 and part2 should be in the same order as in s.

        /// The interviewer gives you the following example and tells you to figure out the rest from the given test cases.

        /// For example:
        /// 'codewars' is a merge from 'cdw' and 'oears':

        /// s:  c o d e w a r s = codewars
        /// part1:  c   d       w         = cdw
        /// part2:    o     e       a r s   = oears
        [Fact]
        public void HappyPath1()
        {
            Assert.True(MergedStringChecker.IsMerge("codewars", "code", "wars"), "codewars can be created from code and wars");
        }

        [Fact]
        public void HappyPath2()
        {
            Assert.True(MergedStringChecker.IsMerge("codewars", "cdwr", "oeas"), "codewars can be created from cdwr and oeas");
        }

        [Fact]
        public void SadPath1()
        {
            Assert.False(MergedStringChecker.IsMerge("codewars", "cod", "wars"), "Codewars are not codwars");
        }

        [Fact]
        public void SecondsToHumanReadableTests()
        {
            Assert.Equal("now", HumanTimeFormat.Duration(0));
            Assert.Equal("1 second", HumanTimeFormat.Duration(1));
            Assert.Equal("1 minute and 2 seconds", HumanTimeFormat.Duration(62));
            Assert.Equal("2 minutes", HumanTimeFormat.Duration(120));
            Assert.Equal("1 hour, 1 minute and 2 seconds", HumanTimeFormat.Duration(3662));
            Assert.Equal("182 days, 1 hour, 44 minutes and 40 seconds", HumanTimeFormat.Duration(15731080));
            Assert.Equal("4 years, 68 days, 3 hours and 4 minutes", HumanTimeFormat.Duration(132030240));
            Assert.Equal("6 years, 192 days, 13 hours, 3 minutes and 54 seconds", HumanTimeFormat.Duration(205851834));
            Assert.Equal("8 years, 12 days, 13 hours, 41 minutes and 1 second", HumanTimeFormat.Duration(253374061));
            Assert.Equal("7 years, 246 days, 15 hours, 32 minutes and 54 seconds", HumanTimeFormat.Duration(242062374));
            Assert.Equal("3 years, 85 days, 1 hour, 9 minutes and 26 seconds", HumanTimeFormat.Duration(101956166));
            Assert.Equal("1 year, 19 days, 18 hours, 19 minutes and 46 seconds", HumanTimeFormat.Duration(33243586));
        }

        [Fact]
        public void HumanReadableTest()
        {
            Assert.Equal("00:00:00", TimeFormat.GetReadableTime(0));
            Assert.Equal("00:00:05", TimeFormat.GetReadableTime(5));
            Assert.Equal("00:01:00", TimeFormat.GetReadableTime(60));
            Assert.Equal("23:59:59", TimeFormat.GetReadableTime(86399));
            Assert.Equal("99:59:59", TimeFormat.GetReadableTime(359999));
        }

        [Fact]
        public void CharacterCountingTest()
        {
            Assert.Equal(0, CharacterCounting.DuplicateCount(""));
            Assert.Equal(0, CharacterCounting.DuplicateCount("abcde"));
            Assert.Equal(2, CharacterCounting.DuplicateCount("aabbcde"));
            Assert.Equal(2, CharacterCounting.DuplicateCount("aabBcde"));
            Assert.Equal(1, CharacterCounting.DuplicateCount("Indivisibility"));
            Assert.Equal(2, CharacterCounting.DuplicateCount("Indivisibilities"));
        }

        [Fact]
        public void EqualSidesArrayTest()
        {
            Assert.Equal(3, EqualSidesArray.FindEvenIndex(new int[] { 1, 2, 3, 4, 3, 2, 1 }));
            Assert.Equal(1, EqualSidesArray.FindEvenIndex(new int[] { 1, 100, 50, -51, 1, 1 }));
            Assert.Equal(-1, EqualSidesArray.FindEvenIndex(new int[] { 1, 2, 3, 4, 5, 6 }));
            Assert.Equal(3, EqualSidesArray.FindEvenIndex(new int[] { 20, 10, 30, 10, 10, 15, 35 }));
        }
        [Fact]
        public void ParenthesesValid()
        {
            Assert.True(Parentheses.ValidParentheses("()"));
        }

        [Fact]
        public void ParenthesesNotVaild()
        {
            Assert.False(Parentheses.ValidParentheses(")(((("));
        }

        [Fact]
        public void ArrayDiffTest()
        {
            Assert.Equal(new int[] { 2 }, ArrayDifference.Calculate(new int[] { 1, 2 }, new int[] { 1 }));
            Assert.Equal(new int[] { 2, 2 }, ArrayDifference.Calculate(new int[] { 1, 2, 2 }, new int[] { 1 }));
            Assert.Equal(new int[] { 1 }, ArrayDifference.Calculate(new int[] { 1, 2, 2 }, new int[] { 2 }));
            Assert.Equal(new int[] { 1, 2, 2 }, ArrayDifference.Calculate(new int[] { 1, 2, 2 }, new int[] { }));
            Assert.Equal(new int[] { }, ArrayDifference.Calculate(new int[] { }, new int[] { 1, 2 }));
        }

        [Fact]
        public void ZeroMoverTest()
        {
            Assert.Equal(new int[] { 1, 2, 1, 1, 3, 1, 0, 0, 0, 0 }, MoveZeroes.Move(new int[] { 1, 2, 0, 1, 0, 1, 0, 3, 0, 1 }));
        }

        [Fact]
        public void CamelKata()
        {
            Assert.Equal("theStealthWarrior", CamelConvertor.ToCamelCase("the_stealth_warrior"));
            Assert.Equal("TheStealthWarrior", CamelConvertor.ToCamelCase("The-Stealth-Warrior"));
            Assert.Equal("theStealthWarrior", CamelConvertor.SmartAss("the_stealth_warrior"));
            Assert.Equal("TheStealthWarrior", CamelConvertor.SmartAss("The-Stealth-Warrior"));
        }

        [Fact]
        public void Mod()
        {
            //var seconds = 7854756;

            //var remainder = 4 % 3;

            //bool even = number % 2 == 0;
        }

        [Fact]
        public void FizzBuzzTest()
        {

        }

        [Fact]
        public void MaxSequenceTest1()
        {

        }

        [Fact]
        public void MaxSequenceTest2()
        {

        }
    }
}
