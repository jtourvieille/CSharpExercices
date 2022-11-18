using CS.Impl._05_Lambdas;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace CS.Tests._05_Lambdas
{
    [TestClass]
    public class MediumLambdasTests
    {
        [TestMethod]
        public void TestCompositionAdditionEtHellowWordFunc()
        {
            // Arrange
            var random = new Random();
            var a = random.Next(int.MaxValue / 2);
            var b = random.Next(int.MaxValue / 2);
            var expected = $"Hello World!{a+b}";

            var compositionFunc = MediumLambdas.GetCompositionAdditionEtHelloWorld();
            // Act

            var result = compositionFunc(a, b);

            // Assert
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void TestGetRecursiveFunc()
        {
            // Arrange
            int n = 10;
            int expected = 55;

            var recursiveFunc = MediumLambdas.GetRecursiveFunc();
            // Act

            var result = recursiveFunc(n);

            // Assert
            Assert.AreEqual(expected, result);
        }
    }
}
