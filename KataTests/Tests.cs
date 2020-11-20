using cSharpKata.Katas;
using Xunit;

namespace KataTests
{
    public class Tests
    {
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
            Assert.Equal(-1,EqualSidesArray.FindEvenIndex(new int[] { 1, 2, 3, 4, 5, 6 }));
            Assert.Equal(3, EqualSidesArray.FindEvenIndex(new int[] { 20, 10, 30, 10, 10, 15, 35 }));
        }
    }
}