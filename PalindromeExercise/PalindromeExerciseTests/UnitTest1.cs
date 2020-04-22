using System;
using Xunit;
using PalindromeExercise;

namespace PalindromeExerciseTests
{
    public class UnitTest1
    {
        [Theory]
        [InlineData("racecar", true)]
        [InlineData("hannah", true)]
        [InlineData("hello", false)]
        [InlineData("sugar", false)]

        public void PalindromeTest (string word, bool expected)
        {
            //arrange
            var sut = new Palindrome();

            //act
            var actual = sut.IsAPalindrome(word);

            //assert
            Assert.Equal(actual, expected);

        }
    }
}
