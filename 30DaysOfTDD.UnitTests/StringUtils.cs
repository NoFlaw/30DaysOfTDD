using System;

namespace _30DaysOfTDD.UnitTests
{
    public class StringUtils
    {
        public int FindNumberOfOccurences(string sentenceToScan, string characterToScanFor)
        {

            if (characterToScanFor.Length != 1 || string.IsNullOrEmpty(characterToScanFor))
                throw new ArgumentException();

            var numberOfOccurenes = 0;
            var characterToCheckFor = Char.Parse(characterToScanFor);
            var stringToCheckAsCharacterArray = sentenceToScan.ToCharArray();

            for (var charIdx = 0; charIdx < stringToCheckAsCharacterArray.GetUpperBound(0); charIdx++)
            {
                if (stringToCheckAsCharacterArray[charIdx] == characterToCheckFor)
                {
                    numberOfOccurenes++;
                }
            }

            return numberOfOccurenes;
        }
    }
}
