namespace StringModification.Tests
{
    public class UnitTest1
    {
        StringModificationMethods stringMethods = new StringModificationMethods();

        [Theory]
        [InlineData("Alabama", "amabalA")]
        [InlineData("I show not your face but your heart's desire.", ".erised s'traeh ruoy tub ecaf ruoy ton wohs I")]
        public void TestBackwordsWord(string originalString, string expected)
        {
            string backwordsString = stringMethods.StringBackwards(originalString);
            Assert.Equal(expected, backwordsString);
        }
        [Theory]
        [InlineData("Alabama", "alabama")]
        [InlineData("I show not your face but your heart's desire.", "i show not your face but your heart's desire.")]
        public void TestAllLowerCase(string originalString, string expected)
        {
            string allLowerCaseString = stringMethods.StringToAllLowerCase(originalString);
            Assert.Equal(expected, allLowerCaseString);
        }
        [Theory]
        [InlineData("Alabama", "ALABAMA")]
        [InlineData("I show not your face but your heart's desire.", "I SHOW NOT YOUR FACE BUT YOUR HEART'S DESIRE.")]
        public void TestAllUpperCase(string originalString, string expected)
        {
            string allUpperCaseString = stringMethods.StringToAllCaps(originalString);
            Assert.Equal(expected, allUpperCaseString);
        }
    }
}