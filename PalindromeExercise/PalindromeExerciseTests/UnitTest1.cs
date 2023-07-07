using System;
using Xunit;
using PalindromeExercise;

namespace PalindromeExerciseTests
{
    public class UnitTest1
    {
        [Theory]
        [InlineData("rotator", true)]
        [InlineData("mom", true)]
        [InlineData("a", true)]
        [InlineData("square", false)]
        [InlineData("sky", false)]


        public static void Test1(string testWord, bool expected)
        {
            //Arrange- skip if static

            //Act
            var actual = WordSmith.IsAPalindrome(testWord);
            //Assert
            Assert.Equal(expected, actual);
        }
    }
}