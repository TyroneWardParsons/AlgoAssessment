using System;
using Xunit;

namespace TGS.Challenge.Tests
{
    public class VowelCountTests
    {
        private readonly VowelCount _vowelCount;

        public VowelCountTests()
        {
            _vowelCount = new VowelCount();
        }

        [Fact]
        public void Value_IsRequired()
        {
            Assert.Throws<ArgumentException>(() => _vowelCount.Count(string.Empty));
        }

        [Fact]
        public void AEIOU_Returns_Correct_Count()
        {
            var count = _vowelCount.Count("AEIOU");

            Assert.Equal(5, count);
        }

        [Fact]
        public void Lmnpqr_Returns_Correct_Count()
        {
            var count = _vowelCount.Count("lmnpqr");

            Assert.Equal(0, count);
        }

        [Fact]
        public void Abcdefghijklmnopqrstuvwxyz_Returns_Correct_Count()
        {
            var count = _vowelCount.Count("abcdefghijklmnopqrstuvwxyz");

            Assert.Equal(5, count);
        }

        [Fact]
        public void Howmanycanyoufind_Returns_Correct_Count()
        {
            var count = _vowelCount.Count("How many can you find");

            Assert.Equal(6, count);
        }
    }
}