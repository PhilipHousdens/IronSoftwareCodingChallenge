using Xunit;
using IronSoftwareCodingChallenge;

namespace IronSoftwareCodingChallenge.Tests
{
    public class OldPhonePadConverterTests
    {
        [Theory]
        [InlineData("2#", "A")]
        [InlineData("22#", "B")]
        [InlineData("222#", "C")]
        [InlineData("7777#", "S")]
        [InlineData("9999#", "Z")]
        public void Decode_RepeatedDigits_ReturnsCorrectLetter(
            string input,
            string expected)
        {
            // Act
            var result = OldPhonePadConverter.OldPhonePadDecoder(input);

            // Assert
            Assert.Equal(expected, result);
        }

        [Fact]
        public void Decode_SpaceSeparatesSameKeyLetters()
        {
            // Act
            var result = OldPhonePadConverter.OldPhonePadDecoder("2 2#");

            // Assert
            Assert.Equal("AA", result);
        }

        [Fact]
        public void Decode_MultipleLetters_ReturnsWord()
        {
            // Act
            var result = OldPhonePadConverter.OldPhonePadDecoder("4433555 555666#");

            // Assert
            Assert.Equal("HELLO", result);
        }

        [Fact]
        public void Decode_Backspace_RemovesLastCharacter()
        {
            // Act
            var result = OldPhonePadConverter.OldPhonePadDecoder("4433555*#");

            // Assert
            Assert.Equal("HE", result);
        }

        [Fact]
        public void Decode_ZeroKey_AddsSpace()
        {
            // Act
            var result = OldPhonePadConverter.OldPhonePadDecoder("44 0 444#");

            // Assert
            Assert.Equal("H I", result);
        }

        [Fact]
        public void Decode_ComplexInput_ReturnsCorrectSentence()
        {
            // Act
            var result = OldPhonePadConverter.OldPhonePadDecoder(
                "4433555 555666096667775553#");

            // Assert
            Assert.Equal("HELLO WORLD", result);
        }
    }
}
