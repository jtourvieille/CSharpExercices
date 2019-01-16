using System.Linq;
using CS.Impl._04_Advanced;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CS.Tests._04_Advanced
{
    [TestClass]
    public class PermutationPrimeTests
    {
        [TestMethod]
        [Description("The number 113, is called a permutation prime because all rotations of the digits: 113, 131, and 311, are themselves prime. There are thirteen such primes below 100: 2, 3, 5, 7, 11, 13, 17, 31, 37, 71, 73, 79, and 97.")]
        public void ShouldFind13PermutationPrimeNumbersBelow100()
        {
            // Arrange
            var subject = new PermutationPrime();

            // Act
            var result = subject.GetPermutationPrimes(100);

            // Assert
            Assert.IsNotNull(result);
            Assert.AreEqual(13, result.Length);
            Assert.IsTrue(result.Contains(2));
            Assert.IsTrue(result.Contains(3));
            Assert.IsTrue(result.Contains(5));
            Assert.IsTrue(result.Contains(7));
            Assert.IsTrue(result.Contains(11));
            Assert.IsTrue(result.Contains(13));
            Assert.IsTrue(result.Contains(17));
            Assert.IsTrue(result.Contains(31));
            Assert.IsTrue(result.Contains(37));
            Assert.IsTrue(result.Contains(71));
            Assert.IsTrue(result.Contains(73));
            Assert.IsTrue(result.Contains(79));
            Assert.IsTrue(result.Contains(97));
        }

        [TestMethod]
        public void ShouldFind22PermutationPrimeNumbersBelow1000()
        {
            // Arrange
            var subject = new PermutationPrime();

            // Act
            var result = subject.GetPermutationPrimes(1000);

            // Assert
            Assert.IsNotNull(result);
            Assert.AreEqual(22, result.Length);
        }
    }
}
