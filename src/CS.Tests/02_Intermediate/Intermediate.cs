using System.Collections.Generic;
using System.Linq;
using CS.Impl._02_Intermediate;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CS.Tests._02_Intermediate
{
    [TestClass]
    public class Intermediate
    {
        [TestMethod]
        [Description("Write a program to print the first n natural number using recursion.")]
        public void FirstNaturalNumbers()
        {
            // Arrange
            var recursion = new Recursion();
            var expected = new List<int> {1, 2, 3, 4, 5, 6, 7, 8, 9, 10};

            // Act
            var actual = recursion.GetNaturalNumbers(10);

            // Assert
            Assert.AreEqual(10, actual.Count());
            foreach (var foundNumber in actual)
            {
                Assert.IsTrue(expected.Contains(foundNumber));
            }
        }

        [TestMethod]
        [Description("Write a program to find the sum of first n natural numbers using recursion.")]
        public void SumFirstNaturalNumbers()
        {
            // Arrange
            var recursion = new Recursion();

            // Act
            var actual = recursion.SumNaturalNumbers(10);

            // Assert
            Assert.AreEqual(55, actual);
        }

        [TestMethod]
        [Description("Write a program to check whether a number is prime or not using recursion.")]
        public void IsPrimeNumber()
        {
            // Arrange
            var recursion = new Recursion();

            // Act
            var is37Prime = recursion.IsPrime(37);
            var is38Prime = recursion.IsPrime(38);

            // Assert
            Assert.IsTrue(is37Prime);
            Assert.IsFalse(is38Prime);
        }

        [TestMethod]
        [Description("Write a program to Check whether a given String is Palindrome or not using recursion.")]
        public void IsPalindrome()
        {
            // Arrange
            var recursion = new Recursion();

            // Act
            var isRadarPalindrome = recursion.IsPalindrome("RADAR");
            var isWrongPalindrome = recursion.IsPalindrome("Wrong");

            // Assert
            Assert.IsTrue(isRadarPalindrome);
            Assert.IsFalse(isWrongPalindrome);
        }
    }
}
