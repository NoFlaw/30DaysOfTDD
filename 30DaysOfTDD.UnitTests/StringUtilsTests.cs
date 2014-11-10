using System;
using NUnit.Framework;

namespace _30DaysOfTDD.UnitTests
{
    [TestFixture]
    public class StringUtilsTest
    {
        private StringUtils _stringUtils;

        [TestFixtureSetUp]
        public void SetupStringUtilTests()
        {
            _stringUtils = new StringUtils();
        }


        [Test]
        public void ShouldBeAbleToCountNumberOfLettersInSimpleSentence()
        {
            const int expectedResult = 2;
            const string characterToScanFor = "e";
            const string sentenceToScan = "TDD is awesome!";

            var result = _stringUtils.FindNumberOfOccurences(sentenceToScan, characterToScanFor);

            Assert.AreEqual(expectedResult, result);
        }

        [Test]
        public void ShouldBeAbleToCountNumberOfLettersInAComplexSentence()
        {
            const int expectedResult = 5;
            const string characterToScanFor = "n";
            const string sentenceToScan = "Once is unique, twice is a coincidence, three times is a pattern.";

            var result = _stringUtils.FindNumberOfOccurences(sentenceToScan, characterToScanFor);

            Assert.AreEqual(expectedResult, result);
        }

        [Test]
        [ExpectedException(typeof(ArgumentException))]
        public void ShouldGetAnArgumentExceptionWhenCharacterToScanForIsLargerThanOneCharacter()
        {
            const string sentenceToScan = "This test should throw an exception";
            const string characterToScanFor = "xx";

            _stringUtils.FindNumberOfOccurences(sentenceToScan, characterToScanFor);
        }


    }
}
