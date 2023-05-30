namespace SpecialChars.Tests
{
    public class UnitTest1
    {
        [Fact]
        public void Example()
        {
            var actual = new Class1().LongestSbustringOfTwoChars("abacaaaabbccbbbabcaa");

            Assert.Equal("bbccbbb", actual);
        }

        [Fact]
        public void ShouldReturnSame()
        {
            var actual = new Class1().LongestSbustringOfTwoChars("abaaa");

            Assert.Equal("abaaa", actual);
        }

        [Fact]
        public void ShouldWorkWithSingleLetter()
        {
            var actual = new Class1().LongestSbustringOfTwoChars("aaaaaaaaaaaa");

            Assert.Equal("abaaa", actual);
        }
    }
}