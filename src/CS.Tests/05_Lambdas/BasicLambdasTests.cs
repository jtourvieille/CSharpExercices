using CS.Impl._05_Lambdas;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace CS.Tests._05_Lambdas
{
    [TestClass]
    public class BasicLambdasTests
    {
        [TestMethod]
        public void TestGetAdditionFunc()
        {
            // Arrange
            var random = new Random();
            var a = random.Next(int.MaxValue / 2);
            var b = random.Next(int.MaxValue / 2);
            var expected = a + b;

            var addtionFunc = BasicLambdas.GetAdditionFunc();
            // Act

            var result = addtionFunc(a, b);

            // Assert
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void TestGetHelloWorldFunc()
        {
            // Arrange
            var expected = "Hello World!";
            var helloWorldFunc = BasicLambdas.GetHelloWorldFunc();
            // Act

            var result = helloWorldFunc();

            // Assert
            Assert.AreEqual(expected, result);
        }
    }
}
